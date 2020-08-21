using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;
    public AudioSource sfxSource;
    public AudioSource bgmSource;
    public List<AudioClip> libraryClip = new List<AudioClip>();

    public void PlaySound(SOUND sound)
    {
        switch (sound)
        {
            case SOUND.CORRECT:
                SetAudioClip(sfxSource, libraryClip[0]);
                break;

            case SOUND.WRONG:
                SetAudioClip(sfxSource, libraryClip[1]);
                break;

            case SOUND.SELECT:
                SetAudioClip(sfxSource, libraryClip[2]);
                break;

            case SOUND.CLAP:
                SetAudioClip(sfxSource, libraryClip[3]);
                break;

            case SOUND.NOTIFICATION:
                SetAudioClip(sfxSource, libraryClip[4]);
                break;
        }

        PlayAudio(sfxSource);
    }

    public void PauseAudio(AudioSource inputSource, bool pause)
    {
        if (pause == true)
        {
            inputSource.Pause();
        }
        else
        {
            inputSource.UnPause();
        }
    }

    private void SetAudioClip(AudioSource inputSource, AudioClip inputClip)
    {
        inputSource.clip = inputClip;
    }

    private void PlayAudio(AudioSource inputSource)
    {
        inputSource.Play();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }
}
