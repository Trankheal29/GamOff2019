using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulManagement : MonoBehaviour
{
    GameObject soulInScene;
    GameObject playerInScene;
    Rigidbody2D rb2D;
    // Update is called once per frame
    
    void Update()
    {
        playerInScene = GameObject.FindGameObjectWithTag("Player");
        soulInScene = GameObject.FindGameObjectWithTag("Soul");
        rb2D = playerInScene.GetComponent<Rigidbody2D>();

        if (soulInScene != null)
        {
            rb2D.velocity = new Vector2(0f, rb2D.velocity.y);
            playerInScene.GetComponent<PlayerMovement>().enabled = false;
            playerInScene.GetComponent<SoulCast>().enabled = false;
        }
        else
        {
            
            playerInScene.GetComponent<PlayerMovement>().enabled = true;
            playerInScene.GetComponent<SoulCast>().enabled = true; 
        }
    }
}
