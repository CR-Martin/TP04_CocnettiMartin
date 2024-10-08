using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;

    private Rigidbody2D _playerRigidbody;
    private const float JumpThreshold = 0.01f;
   // public float Camera_MoveSpeed = 1.5f;
    public float _speed = 3;

    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        CheckAndHandleJump();
        _playerRigidbody.velocity = new Vector2(_speed, _playerRigidbody.velocity.y);
    }

    private void CheckAndHandleJump()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_playerRigidbody.velocity.y) < JumpThreshold)
        {
            _playerRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
