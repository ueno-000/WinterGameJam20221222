using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class ItemBase : MonoBehaviour
{
    [Tooltip("—~‚µ‚¢Obj‚ğİ’è‚·‚é"), SerializeField] protected GameObject[] _getObj;
    [SerializeField, Tooltip("Player‚É‰ÁZ‚·‚éƒXƒRƒA‚ğİ’è")] protected int _plusSore = 0;

    abstract protected void PlayEnter();
}
