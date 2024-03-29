﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCast : MonoBehaviour
{

    public GameObject Soul;
    public GameObject Player;
    Rigidbody2D rbPlayer;
    public bool isGrounded;
    public bool WasGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    Animator anim;


    private void Start()
    {
        rbPlayer = Player.GetComponent<Rigidbody2D>();
        anim = Player.GetComponent<Animator>();
    }

    
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        if(isGrounded == true)
        {
            WasGrounded = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && WasGrounded == true)
        {
            Soul.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1f, 0);
            Instantiate(Soul);
            WasGrounded = false;
            anim.SetBool("Cast", true);
            
          
        }
        
    }
}
