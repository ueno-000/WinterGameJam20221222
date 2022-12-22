using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : ItemBase
{
    string _enterPlayer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _enterPlayer = collision.gameObject.tag;
        PlayEnter();
    }

    protected override void PlayEnter()
    {
        if (_enterPlayer == "Player1")
        {
            GameManager.ScoreOne += _plusSore;
            gameObject.SetActive(false);
        }
        if (_enterPlayer == "Player2")
        {
            GameManager.ScoreTwo += _plusSore;
            gameObject.SetActive(false);
        }
    }

}
