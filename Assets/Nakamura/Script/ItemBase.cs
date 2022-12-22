using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public abstract class ItemBase : MonoBehaviour
{
    [SerializeField, Tooltip("Player‚É‰ÁZ‚·‚éƒXƒRƒA‚ğİ’è")] protected int _plusSore = 0;
    [SerializeField, Tooltip("¶¬‚Ì—Í‰ÁŒ¸")] private float _addPower = 10;
    Rigidbody2D _rd2d;

    private void Awake()
    {
        _rd2d = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        float rad = Random.Range(0, 1 * Mathf.PI);
        var pos = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
        _rd2d.AddForce(pos.normalized * _addPower, ForceMode2D.Impulse);
    }
    abstract protected void PlayEnter();
}
