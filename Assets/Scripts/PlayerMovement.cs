using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
   


    float moveInput;
    Rigidbody2D rb;
   
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }
    // Update is called once per frame
   

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed * Time.deltaTime, rb.velocity.y);
        
    }
}
