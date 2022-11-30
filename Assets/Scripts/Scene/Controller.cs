using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    // Reference Comments.cs Line 8
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] GameObject[] Stars;

    [SerializeField] int intTrackTwoStar;
    [SerializeField] int intTrackOneStar;
    [SerializeField] int intTrackZeroStar;
    int intStarCount = 2;

    // Reference Comments.cs Line 9
    float fltTime = 0f;

    void Start()
    {
        // Reference Comments.cs Line 11
        fltTime = 0f;
    }

    void Update()
    {
        // Reference Comments.cs Line 12
        fltTime += Time.deltaTime;

        // Reference Comments.cs Line 14
        SetTimerTime();
    }

    void SetTimerTime()
    {
        // Reference Comments.cs Line 13
        float fltSeconds = fltTime % 60;
        float fltMinutes = fltTime / 60;
        float fltHours = fltTime / 3600;

        // Reference Comments.cs Line 15
        timer.text = $"{(int)fltHours}:{(int)fltMinutes}:{(int)fltSeconds}";

        if (fltTime > intTrackTwoStar && intStarCount == 2) {
            UpdateStarCount();   
            intStarCount--;
        }
        if (fltTime > intTrackOneStar && intStarCount == 1) {
            UpdateStarCount();   
            intStarCount--;
        }
        if (fltTime > intTrackZeroStar && intStarCount == 0) {
            UpdateStarCount();
        }
        
    }

    void UpdateStarCount()
    {
        Stars[intStarCount].SetActive(false);
    }

    public int GetStarCount()
    {
        return intStarCount;    
    }

    public float GetTime()
    {
        return fltTime;        
    }
}
