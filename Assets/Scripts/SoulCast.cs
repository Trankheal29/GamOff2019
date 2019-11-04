using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCast : MonoBehaviour
{

    public GameObject Soul;
    public GameObject Player;
    Rigidbody2D rbPlayer;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;


    private void Start()
    {
        rbPlayer = Player.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            Soul.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1f, 0);
            Instantiate(Soul);
            isGrounded = false;
            rbPlayer.velocity = new Vector2(0, 0);

        }
        
    }
}
