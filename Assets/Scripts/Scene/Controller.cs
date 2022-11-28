using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    // Reference Comments.cs Line 8
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] GameObject[] Stars;

    int intStarCount = 3;
    
    // Reference Comments.cs Line 9
    float fltTime = 0f;

    // Reference Comments.cs Line 10
    float fltSeconds;
    float fltMinutes;
    float fltHours;

    void Start()
    {
        // Reference Comments.cs Line 11
        fltTime = 0f;
        fltSeconds = 0f;
        fltMinutes = 0f;
        fltHours = 0f;
    }

    void Update()
    {
        // Reference Comments.cs Line 12
        fltTime += Time.deltaTime;

        // Reference Comments.cs Line 13
        fltSeconds = fltTime % 60;
        fltMinutes = fltTime / 60;
        fltHours = fltTime / 3600;

        // Reference Comments.cs Line 14
        SetTimerTime();

        UpdateStarCount();
    }

    void SetTimerTime()
    {
        // Reference Comments.cs Line 15
        timer.text = $"{(int)fltHours}:{(int)fltMinutes}:{(int)fltSeconds}";
    }

    void UpdateStarCount()
    {
        // for (int i = 0; i < Stars.Length; i++)
        // {
        //     Stars[i].SetActive(false);
        // }
    }
}
