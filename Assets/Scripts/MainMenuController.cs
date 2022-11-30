using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Reference Comments.cs Line 8
    [SerializeField] GameObject SettingsMenu;
    [SerializeField] GameObject MainMenu;

    void Start()
    {
        // Reference Comments.cs Line 9
        SettingsMenu.SetActive(false);
        // Reference Comments.cs Line 10
        MainMenu.SetActive(true);
    }

    // Reference Comments.cs Line 11
    public void ClickPlayButton()
    {
        // Reference Comments.cs Line 12
        SceneManager.LoadScene("LevelSelect");
    }

    // Reference Comments.cs Line 13
    public void ClickSettingsButton()
    {
        // Reference Comments.cs Line 14
        SettingsMenu.SetActive(true);
        // Reference Comments.cs Line 15
        MainMenu.SetActive(false);
    }

    // Reference Comments.cs Line 16
    public void ClickQuitButton()
    {
        // Reference Comments.cs Line 17
        Application.Quit();
    }

    // Reference Comments.cs Line 18
    public void ClickSettingsBackButton()
    {
        // Reference Comments.cs Line 19
        SettingsMenu.SetActive(false);
        // Reference Comments.cs Line 20
        MainMenu.SetActive(true);
    }
}
