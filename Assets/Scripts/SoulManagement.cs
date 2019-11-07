using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SoulManagement : MonoBehaviour
{
    GameObject LevelBound;
    GameObject soulInScene;
    GameObject playerInScene;
    CinemachineConfiner camConfinerP;
    CinemachineConfiner camConfinerS;
    Rigidbody2D rb2D;
    Animator anim;
    // Update is called once per frame
    private void Start()
    {
        LevelBound = GameObject.FindGameObjectWithTag("Bound");
    }
    void Update()
    {
        playerInScene = GameObject.FindGameObjectWithTag("Player");
        soulInScene = GameObject.FindGameObjectWithTag("Soul");
        rb2D = playerInScene.GetComponent<Rigidbody2D>();
        anim = playerInScene.GetComponent<Animator>();        
        camConfinerP = playerInScene.GetComponentInChildren<CinemachineConfiner>();

        if (soulInScene != null)
        {
            camConfinerS = soulInScene.GetComponentInChildren<CinemachineConfiner>();
            camConfinerS.m_BoundingShape2D = LevelBound.GetComponent<PolygonCollider2D>();
            rb2D.velocity = new Vector2(0f, rb2D.velocity.y);
            playerInScene.GetComponent<PlayerMovement>().enabled = false;
            playerInScene.GetComponent<SoulCast>().enabled = false;
        }
        else
        {
            camConfinerP.m_BoundingShape2D = LevelBound.GetComponent<PolygonCollider2D>();
            anim.SetBool("Cast", false);
            playerInScene.GetComponent<PlayerMovement>().enabled = true;
            playerInScene.GetComponent<SoulCast>().enabled = true; 
        }
    }
}
