using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : ItemBase
{
    [SerializeField, Tooltip("Player�̈ړ����x��ύX")] private float _valueSpeed = 5;
    /// <summary>�ύX��̑��x</summary>
    public float GetValueSpeed => _valueSpeed;
    private float _keepSpeed = 0;
    [SerializeField, Tooltip("�ړ����x��ύX���鎞��")] private float _valueTime = 0;
    /// <summary>���x��ύX���鎞��</summary>
    public float GetValueTime => _valueTime;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            PlayEnter();
        }
    }
    protected override void PlayEnter()
    {
        gameObject.SetActive(false);
    }
}
