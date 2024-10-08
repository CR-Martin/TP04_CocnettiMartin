using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObstacleMovement : MonoBehaviour
{
    private Rigidbody2D _enemybody;
    [SerializeField] private float _speed;
    public static event Action OnObstacleCollision;

    void Start()
    {
        _enemybody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        _enemybody.velocity = new Vector2(-1 * _speed, _enemybody.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnObstacleCollision?.Invoke();
            Destroy(this.gameObject);
        }
    }
}
