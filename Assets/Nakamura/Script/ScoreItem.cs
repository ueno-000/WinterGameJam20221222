using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : ItemBase
{
    GameManager _getManager;
    string _enterPlayer;
    private void Start()
    {
        _getManager = _getObj[0].GetComponent<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _enterPlayer = collision.gameObject.tag;
        PlayEnter();
    }
    protected override void PlayEnter()
    {
        if (_enterPlayer == "Player1")
        {
            _getManager.ScoreOne += _plusSore;
            gameObject.SetActive(false);
        }
        if (_enterPlayer == "Player2")
        {
            _getManager.ScoreTwo += _plusSore;
            gameObject.SetActive(false);
        }
    }

}
