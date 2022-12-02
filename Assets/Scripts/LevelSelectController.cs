using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectController : MonoBehaviour
{
    // Reference Comments.cs Line 23
    public void ClickLevel1Button()
    {
        // Reference Comments.cs Line 24
        SceneManager.LoadScene("Level 1");
    }
    
    public void ClickLevel2Button()
    {
        // Reference Comments.cs Line 25
        SceneManager.LoadScene("Level 2");
    }

    public void ClickLevel3Button()
    {
        // Reference Comments.cs Line 26
        SceneManager.LoadScene("Level 3");
    }

    public void ClickLevel4Button()
    {
        // Reference Comments.cs Line 27
        SceneManager.LoadScene("Level 4");
    }

    public void ClickLevel5Button()
    {
        // Reference Comments.cs Line 28
        SceneManager.LoadScene("Level 5");
    }

    public void ClickLevel6Button()
    {
        // Reference Comments.cs Line 29
        SceneManager.LoadScene("Level 6");
    }

    public void ClickBackButton()
    {
        // Reference Comments.cs Line 30
        SceneManager.LoadScene("Main Menu");
    }
}
