using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// �v���C���[�̈ړ��p�N���X
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [Tooltip("�ړ����x")]
    [SerializeField] Vector2 _moveSpeed= Vector2.one;
    [Header("�ړ��L�[")]
    [Tooltip("�E")]
    [SerializeField] KeyCode _rightKey = KeyCode.D;
    [Tooltip("��")]
    [SerializeField] KeyCode _leftKey = KeyCode.A;
    [Tooltip("��")]
    [SerializeField] KeyCode _upKey = KeyCode.W;
    [Tooltip("��")]
    [SerializeField] KeyCode _downKey = KeyCode.S;

    [Header("�f�o�b�O�p ��{��1")]
    [Tooltip("�ړ����x�̔{��")]
    [SerializeField] float _moveSpeedFact = 1;
    Rigidbody2D _rb;

    /// <summary>�ړ����x�̔{��</summary>
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
