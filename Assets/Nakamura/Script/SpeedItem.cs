using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : ItemBase
{
    [SerializeField, Tooltip("Playerの移動速度を変更")] private float _valueSpeed = 5;
    /// <summary>変更先の速度</summary>
    public float GetValueSpeed => _valueSpeed;
    private float _keepSpeed = 0;
    [SerializeField, Tooltip("移動速度を変更する時間")] private float _valueTime = 0;
    /// <summary>速度を変更する時間</summary>
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
