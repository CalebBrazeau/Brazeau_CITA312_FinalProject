using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickLevel1Button()
    {
        SceneManager.LoadScene("Level 1");
    }
    
    public void ClickLevel2Button()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void ClickLevel3Button()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void ClickLevel4Button()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void ClickLevel5Button()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void ClickLevel6Button()
    {
        SceneManager.LoadScene("Level 6");
    }

    public void ClickBackButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}