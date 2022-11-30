using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class HandleFinish : MonoBehaviour
{
    [SerializeField] string strNextLevel;
    [SerializeField] Controller controller;

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

        SaveInformation();
        
        SceneManager.LoadScene(strNextLevel);
    }

    void SaveInformation() {
        string strCurrentSceneName = Regex.Replace(SceneManager.GetActiveScene().name, "\\s+", "");
        PlayerPrefs.SetInt(strCurrentSceneName + "StarCount", controller.GetStarCount());     
        PlayerPrefs.SetFloat(strCurrentSceneName + "FinishTime", controller.GetTime());
        PlayerPrefs.Save();
    }
}
