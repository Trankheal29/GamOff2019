﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoulMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float amplitude = 0.5f;
    public float frequency = 1f;

    

    Vector2 moveInput;
    Vector2 moveSpeed;

    Vector3 tempPos = new Vector3();

    Rigidbody2D rb;
    Animator anim;
   
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveSpeed = moveInput.normalized * speed;
        moveCheck();
        
    }

    void FixedUpdate()
    {
        
        rb.position =  rb.position + moveSpeed * Time.deltaTime;
        tempPos = rb.position;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        rb.position = tempPos;
    }

    void moveCheck()
    {
        if (moveInput.x == 0 && moveInput.y == 0)
        {
            anim.SetBool("IsMoving", false);
        }
        else
        {
            anim.SetBool("IsMoving", true);
        }
    }
    

}
