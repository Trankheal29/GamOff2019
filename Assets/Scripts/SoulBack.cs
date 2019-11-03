using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulBack : MonoBehaviour
{
    
    public GameObject soul;
    GameObject playerInScene;
    public GameObject playerRespawn;
    Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        GameObject playerInScene = GameObject.Find("Player");
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            if (playerInScene) {

                rb = playerInScene.GetComponent<Rigidbody2D>();
                rb.velocity = new Vector2(0, 0);
                playerInScene.transform.position = soul.transform.position;
                playerInScene.GetComponent<PlayerMovement>().enabled = true;
                playerInScene.GetComponent<SoulCast>().enabled = true;
                Destroy(soul,0.1f);

            }
            else
            {
                playerRespawn.transform.position = soul.transform.position;
                Instantiate(playerRespawn);
                Destroy(soul);
              
            }


        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (playerInScene)
            {
            playerInScene.GetComponent<PlayerMovement>().enabled = true;
            playerInScene.GetComponent<SoulCast>().enabled = true;
            Destroy(soul);
            }
            else
            {
                Debug.Log("No body available");
            }
        }
    }
}
