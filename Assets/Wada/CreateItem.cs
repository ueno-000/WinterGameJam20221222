using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class CreateItem : MonoBehaviour
{
    [Tooltip("“¯Žž‚É¶¬‚·‚é”"), SerializeField]
    int _synchroNum = 1;

    [Tooltip("¶¬‚·‚éŠÔŠu"), SerializeField]
    float _generateTime = 1f;

    [Tooltip("¶¬‚·‚éêŠ"), SerializeField]
    Transform[] _generatePos;


    [SerializeField]
    Items[] _items;



    void Start()
    {
        StartCoroutine(ItemGenerate());
    }


    void Update()
    {

    }

    private IEnumerator ItemGenerate()
    {
        yield return new WaitForSecondsRealtime(_generateTime);

        int result = UnityEngine.Random.Range(0, _items.Sum(i => i.probability));

        int sum = 0;

        for (int i = 0; i < _items.Length; i++)
        {
            sum += _items[i].probability;
            if (result <= sum)
            {
                ObjectPool.Instance.Use(_items[i].item.gameObject, _generatePos[UnityEngine.Random.Range(0, 3)].position);
                break;
            }
        }
        StartCoroutine(ItemGenerate());
    }


    [System.Serializable]
    public class Items
    {
        public ItemBase item;
        public int probability;
    }
}
