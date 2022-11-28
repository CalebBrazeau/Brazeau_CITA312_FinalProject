using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] GameObject SettingsMenu;
    [SerializeField] GameObject MainMenu;

    void Start()
    {
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    // Method to handle the button click and load the corrisponding scene
    public void ClickPlayButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    // Method to display the settings menu
    public void ClickSettingsButton()
    {
        SettingsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    // Method to quit the game
    public void ClickQuitButton()
    {
        // Quits the application
        Application.Quit();
    }

    public void ClickSettingsBackButton()
    {
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
