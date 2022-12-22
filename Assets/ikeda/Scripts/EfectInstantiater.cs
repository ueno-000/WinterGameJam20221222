using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EfectInstantiater : MonoBehaviour
{
    [Tooltip("�G�t�F�N�g�̃v���n�u")]
    [SerializeField] GameObject _efectObject;
    [Tooltip("�G�t�F�N�g�I�u�W�F�N�g�̐�������")]
    [SerializeField] float _efectTime;

    static EfectInstantiater _instance;
    public static EfectInstantiater Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType<EfectInstantiater>();
                if (!_instance)
                {
                    Debug.LogError($"{typeof(EfectInstantiater)}��������܂���");
                }
            }

            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance)
        {
            Destroy(this);
        }
        _instance = this;
    }


    public void Instantiate(Vector2 point)
    {
        if (_efectObject)
        {
            Destroy(Instantiate(_efectObject, point, Quaternion.identity), _efectTime);
        }
    }

#if UNITY_EDITOR

    private void OnValidate()
    {
        if (_efectTime < 0) { _efectTime = 0; }
    }

#endif
}
