using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Method to handle the button click and load the corrisponding scene
    public void ClickPlayButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    // Method to display the settings menu
    public void ClickSettingsButton()
    {
        Debug.Log("Settings Menu");
        // SceneManager.LoadScene("LevelSelect");
    }

    // Method to quit the game
    public void ClickQuitButton()
    {
        // Quits the application
        Application.Quit();
    }
}
