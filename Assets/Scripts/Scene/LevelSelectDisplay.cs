using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelSelectDisplay : MonoBehaviour
{
    [SerializeField] GameObject[] Stars;
    [SerializeField] TextMeshProUGUI finishTime;

    // Start is called before the first frame update
    void Start()
    {
        int intLevelStarCount = PlayerPrefs.GetInt(gameObject.name + "StarCount");
        float fltLevelFinishedTime = PlayerPrefs.GetFloat(gameObject.name + "FinishTime");

        DisplayStarCount(intLevelStarCount);
        DisplayFinishTime(fltLevelFinishedTime);

    }

    void DisplayStarCount(int intLevelStarCount)
    {
        if (intLevelStarCount == 0) {return;}
        for (int i = 0; i <= intLevelStarCount; i++)
        {
            Stars[i].SetActive(true);
        }
    }

    void DisplayFinishTime(float fltLevelFinishedTime)
    {
        if (fltLevelFinishedTime > 0) {
            float fltSeconds = fltLevelFinishedTime % 60;
            float fltMinutes = fltLevelFinishedTime / 60;
            float fltHours = fltLevelFinishedTime / 3600;

            finishTime.text = $"{(int)fltHours}:{(int)fltMinutes}:{(int)fltSeconds}";
        }
    }
}
