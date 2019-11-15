using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoul : MonoBehaviour
{
    GameObject playerInScene;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInScene = GameObject.FindGameObjectWithTag("Player");
        if (collision.CompareTag("Player"))
        {
            playerInScene.GetComponent<SoulCast>().enabled = true;
            playerInScene.GetComponent<SoulCast>().WasGrounded = true;

        }
    }
}