using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resetinator : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // If the collided object is the player
        if (other.tag == "Player")
        {
            // Get the current scene/level index
            int intCurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            // Reload the current scene/level
            SceneManager.LoadScene(intCurrentSceneIndex);
        }
    }
}
