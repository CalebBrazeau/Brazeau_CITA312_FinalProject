using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    // Reference Comments.cs Line 80
    [SerializeField] TextMeshProUGUI timer;
    // Reference Comments.cs Line 81
    [SerializeField] GameObject[] Stars;

    // Reference Comments.cs Line 82
    [SerializeField] int intTrackTwoStar;
    [SerializeField] int intTrackOneStar;
    [SerializeField] int intTrackZeroStar;
    // Reference Comments.cs Line 83
    int intStarCount = 2;

    // Reference Comments.cs Line 84
    float fltTime = 0f;

    void Start()
    {
        // Reference Comments.cs Line 85
        fltTime = 0f;
    }

    void Update()
    {
        // Reference Comments.cs Line 86
        fltTime += Time.deltaTime;

        // Reference Comments.cs Line 87
        SetTimerTime();
    }

    void SetTimerTime()
    {
        // Reference Comments.cs Line 88
        float fltSeconds = fltTime % 60;
        float fltMinutes = fltTime / 60;
        float fltHours = fltTime / 3600;

        // Reference Comments.cs Line 89
        timer.text = $"{(int)fltHours}:{(int)fltMinutes}:{(int)fltSeconds}";

        // Reference Comments.cs Line 90
        if (fltTime > intTrackTwoStar && intStarCount == 2) {
            // Reference Comments.cs Line 91
            UpdateStarCount();   
            // Reference Comments.cs Line 92
            intStarCount--;
        }
        // Reference Comments.cs Line 93
        if (fltTime > intTrackOneStar && intStarCount == 1) {
            // Reference Comments.cs Line 94
            UpdateStarCount();   
            // Reference Comments.cs Line 95
            intStarCount--;
        }
        // Reference Comments.cs Line 96
        if (fltTime > intTrackZeroStar && intStarCount == 0) {
            // Reference Comments.cs Line 97
            UpdateStarCount();
        }
    }

    // Reference Comments.cs Line 98
    void UpdateStarCount()
    {
    // Reference Comments.cs Line 99
        Stars[intStarCount].SetActive(false);
    }

    // Reference Comments.cs Line 100
    public int GetStarCount()
    {
    // Reference Comments.cs Line 101
        return intStarCount;    
    }

    // Reference Comments.cs Line 102
    public float GetTime()
    {
    // Reference Comments.cs Line 103
        return fltTime;        
    }
}
