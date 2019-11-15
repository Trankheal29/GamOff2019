using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
        Invoke("BlockFall", 0.5f);
        }
    }

    void BlockFall() {

        rb.constraints = ~RigidbodyConstraints2D.FreezePositionY; 
        
    }
}
