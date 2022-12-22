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

    float _moveSpeedFact = 1;
    Rigidbody2D _rb;

    /// <summary>�ړ����x�̔{��</summary>
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
