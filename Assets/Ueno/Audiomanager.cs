using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// âπÇÃä«óù
/// </summary>
public class Audiomanager : MonoBehaviour
{
    [SerializeField] public AudioSource AudioSourseBGM;
    [SerializeField] public AudioSource AudioSourseButton;


    public void AudioPlay(AudioClip audioClip,AudioSource audio)
    {
        Debug.Log(audioClip);
        audio = audio.gameObject.GetComponent<AudioSource>();
        audio.PlayOneShot(audioClip);
    }
}
