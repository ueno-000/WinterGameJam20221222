using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : ItemBase
{
    private void Start()
    {
        //_getObj = GetComponent<T>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayEnter();
    }
    protected override void PlayEnter()
    {
        throw new System.NotImplementedException();
    }

}
