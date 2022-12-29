using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///button‚ÉŽæ‚è•t‚¯‚éAudioManager(Button‚Ì‚Ý)
/// </summary>
public class Audiomanager : MonoBehaviour
{
    [SerializeField] private AudioClip _buttonSE;
    private AudioSource _buttonSourse;

    private Button[] _buttons = default;

    private void Start()
    {
        _buttons= GameObject.FindObjectsOfType<Button>();

        _buttonSourse = GetComponent<AudioSource>();

        foreach (var b in _buttons)
        {
            b.onClick.AddListener(OnClickSE);
        }
    }

    public void OnClickSE()
    {
        _buttonSourse.PlayOneShot(_buttonSE);
    }

}
