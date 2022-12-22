using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class ItemBase : MonoBehaviour
{
    [Tooltip("�~����Obj��ݒ肷��"), SerializeField] protected GameObject[] _getObj;
    [SerializeField, Tooltip("Player�ɉ��Z����X�R�A��ݒ�")] protected int _plusSore = 0;

    abstract protected void PlayEnter();
}
