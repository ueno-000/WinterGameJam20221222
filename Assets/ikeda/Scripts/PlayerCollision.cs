using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D), typeof(PlayerMove))]
public class PlayerCollision : MonoBehaviour
{
    PlayerMove _playerMove;
    Coroutine _coroutine;

    private void Start()
    {
        _playerMove = GetComponent<PlayerMove>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<SpeedItem>(out SpeedItem item))
        {
            if (_coroutine != null) { StopCoroutine(_coroutine); }
            _coroutine = StartCoroutine(SpeedChange(item.GetValueSpeed, item.GetValueTime));
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            Vector2 point = Vector2.Lerp(collision.transform.position, transform.position, 0.5f);
            EfectInstantiater.Instance?.Instantiate(point);
        }
    }




    IEnumerator SpeedChange(float fact, float time)
    {
        _playerMove.MoveSpeedFact = fact;
        yield return new WaitForSeconds(time);
        _playerMove.MoveSpeedFact = 1;
    }
}
