using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void ClickPlayButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void ClickSettingsButton()
    {
        Debug.Log("Settings Menu");
        // SceneManager.LoadScene("LevelSelect");
    }

    public void ClickQuitButton()
    {
        // SceneManager.LoadScene("LevelSelect");
        Debug.Log("Quit Application");
        Application.Quit();
    }
}
