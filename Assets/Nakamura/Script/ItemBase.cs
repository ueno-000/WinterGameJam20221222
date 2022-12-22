using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class ItemBase : MonoBehaviour
{
    [Tooltip("欲しいObjを設定する"), SerializeField] protected GameObject[] _getObj;
    [SerializeField, Tooltip("Playerに加算するスコアを設定")] protected int _plusSore = 0;

    abstract protected void PlayEnter();
}
