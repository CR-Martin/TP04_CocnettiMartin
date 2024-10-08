using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerLife : MonoBehaviour
{
    private bool inmune;
    public static event Action OnGameOver;

    private void OnEnable()
    {
        ObstacleMovement.OnObstacleCollision += CollisionManager;
    }


    private void OnDisable()
    {
        ObstacleMovement.OnObstacleCollision -= CollisionManager;
    }

    void Start()
    {
        SetInmuneFalse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CollisionManager()
    {

        if (!inmune)
        {
            OnGameOver?.Invoke();

        }
        else {
            SetInmuneFalse();
        }
    }

    private void SetInmuneFalse()
    {
        inmune = false;
    }

    private void SetInmuneTrue()
    {
        inmune = false;
    }
}
