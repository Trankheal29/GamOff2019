using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulBack : MonoBehaviour
{
    
    public GameObject soul;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("Player").GetComponent<SoulCast>().enabled = true;
            Destroy(soul);
            
        }

    }
}
