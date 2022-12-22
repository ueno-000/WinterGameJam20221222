using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSE : MonoBehaviour
{
    [SerializeField] private AudioClip _tapSound;

    [SerializeField] private Audiomanager _audiomanager;
    void Start()
    {
        _audiomanager = _audiomanager.gameObject.GetComponent<Audiomanager>();
    }

    public void OnTapButton()
    {
        _audiomanager.AudioPlay(_tapSound,_audiomanager.AudioSourseButton);
    }
}
