using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    float X;
    Vector2 X_Posit;
    public float Speed;
    public float MaxMinPosit;
    public ParticleSystem Dust;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        X = Input.GetAxis("Horizontal");
        X_Posit = transform.position;
        X_Posit.x += X * Speed;
        X_Posit.x = Mathf.Clamp(X_Posit.x,-MaxMinPosit,MaxMinPosit);
        Dust.Play();
        Rb.MovePosition(X_Posit);
    }
}