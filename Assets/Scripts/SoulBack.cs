using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulBack : MonoBehaviour
{
    
    public GameObject soul;
    GameObject playerInScene;
    public GameObject playerRespawn;
    Rigidbody2D rb;
    public float soulDuration = 5f;
    bool contact;
    

    private void OnEnable()
    {
        Destroy(soul, soulDuration);
    }
    // Update is called once per frame
    void Update()
    {
        GameObject playerInScene = GameObject.FindGameObjectWithTag("Player");

        
        
        if (Input.GetKeyDown(KeyCode.Space) && contact == false)
        {
           
            if (playerInScene) {

                rb = playerInScene.GetComponent<Rigidbody2D>();
                rb.velocity = new Vector2(0, 0);
                playerInScene.transform.position = soul.transform.position;
                Destroy(soul);

            }
            else
            {
                playerRespawn.transform.position = soul.transform.position;
                Instantiate(playerRespawn);
                Destroy(soul);
              
            }


        }else if (Input.GetKeyDown(KeyCode.Space) && contact == true)
        {
            Debug.Log("NO SPACE");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (playerInScene)
            {
                 Destroy(soul);
                
            }
            else
            {
                Debug.Log("No body available");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        contact = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        contact = false;
    }
}
