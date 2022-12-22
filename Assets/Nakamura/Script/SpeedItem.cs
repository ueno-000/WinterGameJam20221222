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
    bool _isPlay = false;
    PlayerMove _move;
    float time = 0;
    private void Start()
    {
        for (int i = 0; i < _getObj.Length; i++)
        {
            _move = _getObj[0].GetComponent<PlayerMove>();
        }
    }

    //private void Update()
    //{
    //    if (_isPlay)
    //    {
    //        time += Time.deltaTime;
    //        PlayEnter();
    //    }
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        _isPlay = true;
    //    }
    //}
    protected override void PlayEnter()
    {
        //if (time < _valueTime)
        //{
        //    _keepSpeed = _move.MoveSpeedFact;
        //    _move.MoveSpeedFact = _valueSpeed;
        //}
        //else if (time > _valueTime)
        //{
        //    _isPlay = false;
        //    _move.MoveSpeedFact = _keepSpeed;
        //    time = 0;
        //    gameObject.SetActive(false);
        //}
    }
}
