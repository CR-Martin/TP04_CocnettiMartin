using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinMovement : MonoBehaviour
{
    private Rigidbody2D _coinbody;
    [SerializeField] private float _speed;
    public static event Action OnCoinCollision;

    void Start()
    {
        _coinbody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        _coinbody.velocity = new Vector2(-1 * _speed, _coinbody.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnCoinCollision?.Invoke();
            Destroy(this.gameObject);
        }
    }
}
