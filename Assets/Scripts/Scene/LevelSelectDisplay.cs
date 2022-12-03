using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelSelectDisplay : MonoBehaviour
{
    // Reference Comments.cs Line 122
    [SerializeField] GameObject[] Stars;
    // Reference Comments.cs Line 123
    [SerializeField] TextMeshProUGUI finishTime;

    void Start()
    {
        // Reference Comments.cs Line 124
        int intLevelStarCount = PlayerPrefs.GetInt(gameObject.name + "StarCount");
        // Reference Comments.cs Line 125
        float fltLevelFinishedTime = PlayerPrefs.GetFloat(gameObject.name + "FinishTime");

        // Reference Comments.cs Line 126
        DisplayStarCount(intLevelStarCount);
        // Reference Comments.cs Line 127
        DisplayFinishTime(fltLevelFinishedTime);
    }

    // Reference Comments.cs Line 128
    void DisplayStarCount(int intLevelStarCount)
    {
        // Reference Comments.cs Line 129
        if (intLevelStarCount <= 0) {return;}

        // Reference Comments.cs Line 130
        for (int i = 0; i <= intLevelStarCount; i++)
        {
            // Reference Comments.cs Line 131
            Stars[i].SetActive(true);
        }
    }

    // Reference Comments.cs Line 132
    void DisplayFinishTime(float fltLevelFinishedTime)
    {
        // Reference Comments.cs Line 133
        if (fltLevelFinishedTime <= 0) { return; }

        // Reference Comments.cs Line 134
        float fltSeconds = fltLevelFinishedTime % 60;
        // Reference Comments.cs Line 135
        float fltMinutes = fltLevelFinishedTime / 60;
        // Reference Comments.cs Line 136
        float fltHours = fltLevelFinishedTime / 3600;
        
        // Reference Comments.cs Line 137
        finishTime.text = $"{(int)fltHours}:{(int)fltMinutes}:{(int)fltSeconds}";
    }
}
