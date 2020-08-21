using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    public string menuName;
    public string sceneName;
    private bool isLandscape = false;

    public void LoadScene(SCENE inputScene)
    {
        SoundController.instance.PlaySound(SOUND.SELECT);

        switch (inputScene)
        {
            case SCENE.MATERI1_1:
                SceneManager.LoadScene(Config.materi1_1Scene);
                break;

            case SCENE.MATERI1_2:
                SceneManager.LoadScene(Config.materi1_2Scene);
                break;

            case SCENE.MATERI1_3:
                SceneManager.LoadScene(Config.materi1_3Scene);
                break;

            case SCENE.MATERI1_4:
                SceneManager.LoadScene(Config.materi1_4Scene);
                break;

            case SCENE.MATERI2_1:
                SceneManager.LoadScene(Config.materi2_1Scene);
                break;

            case SCENE.MATERI2_2:
                SceneManager.LoadScene(Config.materi2_2Scene);
                break;

            case SCENE.MATERI2_3:
                SceneManager.LoadScene(Config.materi2_3Scene);
                break;

            case SCENE.MATERI3_1:
                SceneManager.LoadScene(Config.materi3_1Scene);
                break;

            case SCENE.MATERI3_2:
                SceneManager.LoadScene(Config.materi3_2Scene);
                break;

            case SCENE.MATERI3_3:
                SceneManager.LoadScene(Config.materi3_3Scene);
                break;

            case SCENE.MATERI4_1:
                SceneManager.LoadScene(Config.materi4_1Scene);
                break;

            case SCENE.MATERI4_2:
                SceneManager.LoadScene(Config.materi4_2Scene);
                break;

            case SCENE.MATERI4_3:
                SceneManager.LoadScene(Config.materi4_3Scene);
                break;

            case SCENE.MATERI5_1:
                SceneManager.LoadScene(Config.materi5_1Scene);
                break;

            case SCENE.MATERI5_2:
                SceneManager.LoadScene(Config.materi5_2Scene);
                break;

            case SCENE.MATERI5_3:
                SceneManager.LoadScene(Config.materi5_3Scene);
                break;

            case SCENE.MATERI6_1:
                SceneManager.LoadScene(Config.materi6_1Scene);
                break;

            case SCENE.MATERI6_2:
                SceneManager.LoadScene(Config.materi6_2Scene);
                break;

            case SCENE.MATERI6_3:
                SceneManager.LoadScene(Config.materi6_3Scene);
                break;

            case SCENE.MENU:
                SceneManager.LoadScene(Config.menuScene);
                break;

            case SCENE.SUBMENU:
                SceneManager.LoadScene(Config.subMenuScene);
                break;

            case SCENE.ASOSIASI:
                SceneManager.LoadScene(Config.asosiasiScene);
                break;

            case SCENE.VIDEO:
                SoundController.instance.PauseAudio(SoundController.instance.bgmSource, true);
                SceneManager.LoadScene(Config.videoScene);
                break;

            case SCENE.SOAL_LATIHAN:
                SceneManager.LoadScene(Config.kuisScene);
                break;

            case SCENE.KD:
                SceneManager.LoadScene(Config.kdScene);
                break;

            case SCENE.DAFTAR_PUSTAKA:
                SceneManager.LoadScene(Config.daftarPustakaScene);
                break;

            case SCENE.LOGIN:
                SceneManager.LoadScene(Config.loginScene);
                break;

            case SCENE.PETUNJUK:
                SceneManager.LoadScene(Config.petunjukScene);
                break;

            case SCENE.PROFIL:
                SceneManager.LoadScene(Config.profilScene);
                break;

            case SCENE.HALAMAN_MENU:
                SceneManager.LoadScene(Config.halamanMenuScene);
                break;

            case SCENE.INDIKATOR:
                SceneManager.LoadScene(Config.indikatorScene);
                break;

            case SCENE.WELCOME:
                SceneManager.LoadScene(Config.welcomeScene);
                break;
        }
    }

    public IEnumerator LoadSceneCoroutine(SCENE inputScene)
    {
        yield return null;
        LoadScene(inputScene);
    }


    public void SetOrientation(ORIENTATION orientation)
    {
        switch (orientation)
        {
            case ORIENTATION.LANDSCAPE:
                if (isLandscape == false)
                {
                    Screen.orientation = ScreenOrientation.LandscapeLeft;
                    Debug.Log("set to landscape");
                    isLandscape = true;
                }
                break;

            case ORIENTATION.PORTRAIT:
                if (isLandscape == true)
                {
                    Screen.orientation = ScreenOrientation.Portrait;
                    Debug.Log("set to portrait");
                    isLandscape = false;
                }
                break;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {

        sceneName = SceneManager.GetActiveScene().name;

        if (sceneName != Config.videoScene && isLandscape == true)
        {
            SetOrientation(ORIENTATION.PORTRAIT);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (sceneName)
            {
                case Config.subMenuScene:
                    LoadScene(SCENE.MENU);
                    break;

                case Config.videoScene:
                    SoundController.instance.PauseAudio(SoundController.instance.bgmSource, false);
                    LoadScene(SCENE.SUBMENU);
                    break;

                case Config.kuisScene:
                    if (SceneLoader.instance.menuName == Config.halamanMenuScene)
                    {
                        LoadScene(SCENE.HALAMAN_MENU);
                    }
                    else
                    {
                        LoadScene(SCENE.SUBMENU);
                    }
                    break;

                case Config.menuScene:
                    LoadScene(SCENE.HALAMAN_MENU);
                    break;

                case Config.daftarPustakaScene:
                    LoadScene(SCENE.HALAMAN_MENU);
                    break;

                case Config.kdScene:
                    LoadScene(SCENE.HALAMAN_MENU);
                    break;

                case Config.profilScene:
                    LoadScene(SCENE.HALAMAN_MENU);
                    break;

                case Config.indikatorScene:
                    LoadScene(SCENE.KD);
                    break;

                case Config.petunjukScene:
                    LoadScene(SCENE.HALAMAN_MENU);
                    break;

            }
        }

    }
}
