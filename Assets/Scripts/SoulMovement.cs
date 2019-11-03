using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;


    Vector2 moveInput;
    Vector2 moveSpeed;
 
    Rigidbody2D rb;
    



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveSpeed = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        
        rb.position =  rb.position + moveSpeed * Time.deltaTime;

    }
}
