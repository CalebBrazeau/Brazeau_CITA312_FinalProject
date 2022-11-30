using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] AudioClip EWAH;

    float fltWaitTime = 3f;

    AudioSource audioSource;
    
    void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void playEWAH()
    {
        anim.speed = 0;
        audioSource.Play();
        StartCoroutine(GoToMainMenu());
    }

    IEnumerator GoToMainMenu()
    {
        while (true)
        {
            yield return new WaitForSeconds(fltWaitTime);
            SceneManager.LoadScene("Main Menu");
        }
    }
}
