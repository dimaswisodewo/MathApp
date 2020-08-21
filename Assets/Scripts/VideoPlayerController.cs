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
    
    private void Awake()
    {
        SceneLoader.instance.SetOrientation(ORIENTATION.LANDSCAPE);

        switch (SceneLoader.instance.menuName)
        {
            case Config.menuName1:
                videoPlayer.clip = libraryVideoClip[0];
                break;

            case Config.menuName2:
                videoPlayer.clip = libraryVideoClip[1];
                break;

            case Config.menuName3:
                videoPlayer.clip = libraryVideoClip[2];
                break;

            case Config.menuName4:
                videoPlayer.clip = libraryVideoClip[3];
                break;

            case Config.menuName5:
                videoPlayer.clip = libraryVideoClip[4];
                break;

            case Config.menuName6:
                videoPlayer.clip = libraryVideoClip[5];
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
