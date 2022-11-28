using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleFinish : MonoBehaviour
{
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // If the collided object is the player
        if (other.tag == "Player")
        {
            Finish();
        }
    }

    // Method to handle the finish event
    void Finish()
    {
        Debug.Log("I finished on your mom");
    }
}
