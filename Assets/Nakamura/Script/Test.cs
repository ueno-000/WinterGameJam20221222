using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    float th = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rad = 180 * Mathf.Deg2Rad;
        var pos = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
        gameObject.transform.position = pos;
        //th += 1;
    }
}
