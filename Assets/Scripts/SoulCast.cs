using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCast : MonoBehaviour
{

    public GameObject Soul;
    public GameObject Player;
   
   

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Soul.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1f, 0);
            Instantiate(Soul);
            Player.GetComponent<PlayerMovement>().enabled = false;
            Player.GetComponent<SoulCast>().enabled = false;
            
            
        }
        
    }
}
