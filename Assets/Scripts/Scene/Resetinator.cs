using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resetinator : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Reference Comments.cs Line 168
        if (other.tag == "Player")
        {
            // Reference Comments.cs Line 169
            int intCurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            
            // Reference Comments.cs Line 170
            SceneManager.LoadScene(intCurrentSceneIndex);
        }
    }
}
