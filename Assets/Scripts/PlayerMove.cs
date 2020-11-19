﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 1f;
    public Rigidbody2D rb;

    private Vector2 moveDirection;
    private Vector2 mousePos;

    public Camera cam;



    // Update is called once per frame
    void Update()
    {
        ProcessInputs();

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    //Good for physics calculations
    void FixedUpdate()
    {
        RotatePlayer();
        Move();

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

    void ProcessInputs()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");
    }

    void Move()
    {
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    void RotatePlayer()
    {

    }
}