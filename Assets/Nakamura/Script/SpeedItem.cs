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
