using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{
      
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");
        Destroy(collision.gameObject);
        
    }
}
