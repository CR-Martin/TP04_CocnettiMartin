using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;

    private Rigidbody2D _playerRigidbody;
    private const float JumpThreshold = 0.01f;

    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        CheckAndHandleJump();
    }

    private void CheckAndHandleJump()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_playerRigidbody.velocity.y) < JumpThreshold)
        {
            //AudioManager.Instance.PlayEffect("Hit Sound");
            _playerRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
