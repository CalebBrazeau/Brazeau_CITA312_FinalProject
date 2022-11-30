using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleFinish : MonoBehaviour
{
    [SerializeField] string strNextLevel;

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
        if (strNextLevel != null) {
            SceneManager.LoadScene("LevelSelect");
        }

        SceneManager.LoadScene(strNextLevel);
    }
}
