using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _invisiblebody;

    public float _speed = 3;
    void Start()
    {
        _invisiblebody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        _invisiblebody.velocity = new Vector2( _speed, _invisiblebody.velocity.y);

    }
}
