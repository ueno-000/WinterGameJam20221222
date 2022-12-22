using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ÉvÉåÉCÉÑÅ[ÇÃå©ÇΩñ⁄
/// </summary>
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerSprite : MonoBehaviour
{
    [SerializeField] Sprite[] _sprites;
    [SerializeField] float _animTime = 0.1f;

    SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        if (!_spriteRenderer)
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }
        StartCoroutine(Animation());
    }



    IEnumerator Animation()
    {
        if(_sprites == null || _sprites.Length < 1 || !_spriteRenderer) { yield break; }
        int index = 0;
        _spriteRenderer.sprite = _sprites[index];
        while (true)
        {
            yield return new WaitForSeconds(_animTime);
            index = index + 1 < _sprites.Length ? index + 1 : 0;
            _spriteRenderer.sprite = _sprites[index];
        }
    }



#if UNITY_EDITOR

    private void OnValidate()
    {
        if (!_spriteRenderer)
        {
            _spriteRenderer= GetComponent<SpriteRenderer>();
        }
        if (_sprites != null && _sprites.Length > 0)
        {
            _spriteRenderer.sprite = _sprites[0];
        }
        _animTime = _animTime < 0 ? 0 : _animTime;  
    }

#endif
}
