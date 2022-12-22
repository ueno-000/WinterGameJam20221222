using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObjectPool : MonoBehaviour
{
    [SerializeField] GameObject _box;

    void Start()
    {
        StartCoroutine(CreateObj());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator CreateObj()
    {
        yield return new WaitForSecondsRealtime(1);
        if(ObjectPool.Instance.GetCount(_box) < 10)
        {
            ObjectPool.Instance.Use(_box, this.transform.position);
        }
        Debug.Log(1);
        StartCoroutine(CreateObj());
    }
}
