using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class ItemBase : MonoBehaviour
{
    [SerializeField, Tooltip("Player�ɉ��Z����X�R�A��ݒ�")] protected int _plusSore = 0;

    abstract protected void PlayEnter();
}
