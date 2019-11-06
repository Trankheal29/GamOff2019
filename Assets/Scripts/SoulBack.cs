using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulBack : MonoBehaviour
{
    
    public GameObject soul;
    GameObject playerInScene;
    public GameObject playerRespawn;
    Rigidbody2D rb;
    Animator anim;


    private void OnEnable()
    {
        Destroy(soul, 5);
    }
    // Update is called once per frame
    void Update()
    {
        GameObject playerInScene = GameObject.FindGameObjectWithTag("Player");
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            if (playerInScene) {

                rb = playerInScene.GetComponent<Rigidbody2D>();
                anim = playerInScene.GetComponent<Animator>();
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
}
