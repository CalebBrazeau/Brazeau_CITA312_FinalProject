using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;

    float fltMilliseconds;
    float fltSeconds;
    int fltMinutes;

    string formatMilliseconds = "00";
    string formatSeconds = "00";

    void Start()
    {
        fltMilliseconds = 0f;
        fltSeconds = 50f;
        fltMinutes = 0;
    }

    void Update()
    {
        SetTimerTime();
        fltSeconds += Time.deltaTime;
    }

    void SetTimerTime()
    {
        // If 59 seconds has passed
        if (fltSeconds >= 59f) {
            // Add one to minutes variable
            fltMinutes++;
            // Reset seconds counter
            fltSeconds = 0f;
        }
        
        formatSeconds = fltSeconds.ToString().Split('.')[0];

        if (fltSeconds.ToString().Split('.').Length >= 2) {
            formatMilliseconds = Mathf.Round(int.Parse(fltSeconds.ToString().Split('.')[1]) / 1000).ToString();
        }

        string formatedTime = string.Format("{0}:{1}:{2}", fltMinutes, formatSeconds, formatMilliseconds);
        timer.text = formatedTime;
    }
}
