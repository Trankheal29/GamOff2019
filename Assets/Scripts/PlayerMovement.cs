using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float climbSpeed;
    float moveInput;
    float climbInput;
    public float wallCheckDistance;

    private Vector2 ledgePosBot;


    Rigidbody2D rb;


    public Transform ledgeCheck;
    public Transform wallCheck;

    public LayerMask whatIsGround;

    private bool isFacingRight = true;
    private bool isTouchingWall;
    private bool isTouchingLedge;
    private bool canClimbLedge = false;
    private bool ledgeDetected = false;
   
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }
    // Update is called once per frame

    private void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        climbInput = Input.GetAxisRaw("Vertical");
        CheckSurroundings();
        DirectionCheck();
    }

    void FixedUpdate()
    {
        
         rb.velocity = new Vector2(moveInput * speed * Time.deltaTime, rb.velocity.y);
        if(ledgeDetected == true && climbInput > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, climbInput * climbSpeed * Time.deltaTime);
            ledgeDetected = false;

        }
        
    }

    void DirectionCheck()
    {
        if(moveInput > 0 && !isFacingRight)
        {
            isFacingRight = !isFacingRight;
            transform.localScale = new Vector3(1f, 1f, 0);

        }
        else if(moveInput<0 && isFacingRight)
        {
            isFacingRight = !isFacingRight;
            transform.localScale = new Vector3(-1f, 1f, 0);
        }
    }

    private void CheckSurroundings()
    {
        isTouchingWall = Physics2D.Raycast(wallCheck.position, transform.right, wallCheckDistance, whatIsGround);
        isTouchingLedge = Physics2D.Raycast(ledgeCheck.position, transform.right, wallCheckDistance, whatIsGround);

        if(isTouchingWall && !isTouchingLedge && !ledgeDetected)
        {
            ledgeDetected = true;
        }
    }

}
