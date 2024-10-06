using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private Rigidbody2D _playerRigidbody;
    [SerializeField] private float _speed;
    
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        _playerRigidbody.velocity = new Vector2(-1 * _speed, _playerRigidbody.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Debug.Log("Time stops");
        }
    }
}
