using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;

public class HandleFinish : MonoBehaviour
{
    // Reference Comments.cs Line 106
    [SerializeField] string strNextLevel;
    // Reference Comments.cs Line 107
    [SerializeField] Controller controller;

    void OnTriggerEnter(Collider other)
    {
        // Reference Comments.cs Line 108
        if (other.tag == "Player")
        {
            // Reference Comments.cs Line 109
            Finish();
        }
    }

    // Reference Comments.cs Line 110
    void Finish()
    {
        // Reference Comments.cs Line 111
        if (strNextLevel == null) {
            // Reference Comments.cs Line 112
            SceneManager.LoadScene("LevelSelect");
        }

        // Reference Comments.cs Line 113
        SaveInformation();
        
        // Reference Comments.cs Line 114
        SceneManager.LoadScene(strNextLevel);
    }

    // Reference Comments.cs Line 115
    void SaveInformation() {
        // Reference Comments.cs Line 116
        string strCurrentSceneName = Regex.Replace(SceneManager.GetActiveScene().name, "\\s+", "");
        
        // Reference Comments.cs Line 117
        PlayerPrefs.SetInt(strCurrentSceneName + "StarCount", controller.GetStarCount());     
        // Reference Comments.cs Line 118
        PlayerPrefs.SetFloat(strCurrentSceneName + "FinishTime", controller.GetTime());
        
        // Reference Comments.cs Line 119
        PlayerPrefs.Save();
    }
}
