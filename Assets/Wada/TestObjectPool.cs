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
        //Debug.Log(Random.Range(1, 101));
    }

    private IEnumerator CreateObj()
    {
        yield return new WaitForSecondsRealtime(1);
        if(ObjectPool.Instance.GetCount(_box) < 40)
        {
            ObjectPool.Instance.Use(_box, this.transform.position);
        }
        //Debug.Log(1);
        StartCoroutine(CreateObj());
    }
}
