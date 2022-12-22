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
    [Header("移動キー")]
    [Tooltip("右")]
    [SerializeField] KeyCode _rightKey = KeyCode.D;
    [Tooltip("左")]
    [SerializeField] KeyCode _leftKey = KeyCode.A;
    [Tooltip("上")]
    [SerializeField] KeyCode _upKey = KeyCode.W;
    [Tooltip("下")]
    [SerializeField] KeyCode _downKey = KeyCode.S;

    [Header("デバッグ用 基本は1")]
    [Tooltip("移動速度の倍率")]
    [SerializeField] float _moveSpeedFact = 1;
    Rigidbody2D _rb;

    /// <summary>移動速度の倍率</summary>
    public float MoveSpeedFact { get => _moveSpeedFact; set => _moveSpeedFact = value; }
    // Start is called before the first frame update
    void Start()
    {
        _rb= GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vec = new();
        if (Input.GetKey(_rightKey))
        {
            vec.x++;
        }
        if(Input.GetKey(_leftKey))
        {
            vec.x--;
        }
        if (Input.GetKey(_upKey))
        {
            vec.y++;
        }
        if (Input.GetKey(_downKey))
        {
            vec.y--;
        }

        _rb.velocity = new Vector2(_moveSpeed.x * vec.x, _moveSpeed.y * vec.y) * _moveSpeedFact;
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
