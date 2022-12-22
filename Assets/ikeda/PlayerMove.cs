using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// プレイヤーの移動用クラス
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [Tooltip("移動速度")]
    [SerializeField] Vector2 _moveSpeed= Vector2.one;

    float _moveSpeedFact = 1;
    Rigidbody2D _rb;

    /// <summary>移動速度の倍率</summary>
    public float MoveSpeedFact => _moveSpeedFact;
    // Start is called before the first frame update
    void Start()
    {
        _rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vec = new();

    }


#if UNITY_EDITOR

    private void OnValidate()
    {
        if(_moveSpeed.x < 0)
        {
            _moveSpeed.x = 0;
        }
        if(_moveSpeed.y < 0)
        {
            _moveSpeed.y = 0;
        }
    }

#endif
}
