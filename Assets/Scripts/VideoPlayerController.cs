using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class VideoPlayerController : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public VideoPlayer videoPlayer;
    public Slider slider;
    public List<VideoClip> libraryVideoClip = new List<VideoClip>();
    public Text sourceText;
    private List<string> librarySource = new List<string>();
    private bool isSliding = false;

    public void OnPointerUp(PointerEventData eventData)
    {
        float frame = (float)slider.value * (float)videoPlayer.frameCount;
        videoPlayer.frame = (long)frame;
        isSliding = false;
        Debug.Log("Mouse Up");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isSliding = true;
        Debug.Log("Mouse Down");
    }
    
    private void SetSourceText(string inputString)
    {
        sourceText.text = inputString;
    }

    private void AddLibrarySource()
    {
        librarySource.Add("Pertiwi, B.T.2017.Video Pembelajaran(Video Scribe)-Untung Rugi.(Online).https://www.youtube.com/watch?v=gmeeGRDnHmk.Diakses pada 9 Januari 2020.");
        librarySource.Add("Green, R.A.2018.Matematika - Persentase Untung dan Rugi.(Online).https://www.youtube.com/watch?v=ej693-j-Dwc.Diakses pada 9 Januari 2020.");
        librarySource.Add("Green, R.A.2018.Bagaimana Matematika Diskon (Rabat).(Online).https://www.youtube.com/watch?v=gp6YJogk_fM.Diakses pada 9 Januari 2020.");
        librarySource.Add("Coz, A.2017.Cara Menghitung Pajak PErtambahan Nilai PPN. (Online). https://www.youtube.com/watch?v=4IKOjRs_y9w&list=PLCX_CJrO90ZSz60o8oUB59tqi0kWoyeo7&index=16. Diakses pada 9 Januari 2020.");
        librarySource.Add("Zulfitri, H.2018.Videoscribe pembelajaran matematika materi bunga dan tabungan.(Online).https://www.youtube.com/watch?v=Chf5j-YTdf8&t=217s.Diakses pada 9 Januari 2020.");
        librarySource.Add("Belajar, T.2017.Perbedaan Bruto, Netto & Tara.(Onlline).https://www.youtube.com/watch?v=HAKIvdhni4E.Diakses pada 9 Januari 2020.");
    }

    private void Awake()
    {
        AddLibrarySource();
        SceneLoader.instance.SetOrientation(ORIENTATION.LANDSCAPE);

        switch (SceneLoader.instance.menuName)
        {
            case Config.menuName1:
                videoPlayer.clip = libraryVideoClip[0];
                SetSourceText(librarySource[0]);
                break;

            case Config.menuName2:
                videoPlayer.clip = libraryVideoClip[1];
                SetSourceText(librarySource[1]);
                break;

            case Config.menuName3:
                videoPlayer.clip = libraryVideoClip[2];
                SetSourceText(librarySource[2]);
                break;

            case Config.menuName4:
                videoPlayer.clip = libraryVideoClip[3];
                SetSourceText(librarySource[3]);
                break;

            case Config.menuName5:
                videoPlayer.clip = libraryVideoClip[4];
                SetSourceText(librarySource[4]);
                break;

            case Config.menuName6:
                videoPlayer.clip = libraryVideoClip[5];
                SetSourceText(librarySource[5]);
                break;
        }

        SoundController.instance.PauseAudio(SoundController.instance.bgmSource, true);
    }

    private void Update()
    {
        if (!isSliding && videoPlayer.isPlaying)
        {
            slider.value = (float)videoPlayer.frame / (float)videoPlayer.frameCount;
        }
    }

}
