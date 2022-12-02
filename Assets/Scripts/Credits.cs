using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    // Reference Comments.cs Line 33
    [SerializeField] Animator anim;
    // Reference Comments.cs Line 34
    [SerializeField] AudioClip EWAH;

    // Reference Comments.cs Line 35
    float fltWaitTime = 3f;

    // Reference Comments.cs Line 36
    AudioSource audioSource;
    
    void Start() 
    {
        // Reference Comments.cs Line 37
        audioSource = GetComponent<AudioSource>();
    }

    public void playEWAH()
    {
        // Reference Comments.cs Line 38
        anim.speed = 0;
        // Reference Comments.cs Line 39
        audioSource.Play();
        // Reference Comments.cs Line 40
        StartCoroutine(GoToMainMenu());
    }

    IEnumerator GoToMainMenu()
    {
        // Reference Comments.cs Line 41
        while (true)
        {
            // Reference Comments.cs Line 42
            yield return new WaitForSeconds(fltWaitTime);
            // Reference Comments.cs Line 43
            SceneManager.LoadScene("Main Menu");
        }
    }
}
