using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EfectInstantiater : MonoBehaviour
{
    [Tooltip("エフェクトのプレハブ")]
    [SerializeField] GameObject _efectObject;
    [Tooltip("エフェクトオブジェクトの生存時間")]
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
                    Debug.LogError($"{typeof(EfectInstantiater)}が見つかりません");
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
