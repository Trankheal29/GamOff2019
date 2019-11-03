using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulManagement : MonoBehaviour
{
    GameObject soulInScene;
    GameObject playerInScene;
    // Update is called once per frame
    void Update()
    {
        playerInScene = GameObject.FindGameObjectWithTag("Player");
        soulInScene = GameObject.FindGameObjectWithTag("Soul");

        if (soulInScene != null)
        {
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
