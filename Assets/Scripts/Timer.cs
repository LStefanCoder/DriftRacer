using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    //based on https://www.youtube.com/watch?v=hxpUk0qiRGs

    //based on https://medium.com/@eveciana21/creating-a-stopwatch-timer-in-unity-f4dff748030d

    private bool timerActive;
    private float currentTime;
    [SerializeField] private TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
       if (timerActive)
        {
            //always adding the time
            currentTime = currentTime + Time.deltaTime;
        }

        //splitting up the minutes, seconds and milliseconds to separate strings with the TimeSpan class
        TimeSpan timespan = TimeSpan.FromSeconds(currentTime);

        //this if statement prevents the timer from annoyingly jumping when the milliseconds part doesn't have three digits
        if (timespan.Milliseconds == 1000)
        {
            timerText.text = timespan.Minutes.ToString() + " : " + timespan.Seconds.ToString() + " : 000";
        }
        else if (timespan.Milliseconds.ToString().Length == 1)
        {
            timerText.text = timespan.Minutes.ToString() + " : " + timespan.Seconds.ToString() + " : 00" + timespan.Milliseconds.ToString();
        }
        else if (timespan.Milliseconds.ToString().Length == 2)
        {
            timerText.text = timespan.Minutes.ToString() + " : " + timespan.Seconds.ToString() + " : 0" + timespan.Milliseconds.ToString();
        }
        else
        {
            timerText.text = timespan.Minutes.ToString() + " : " + timespan.Seconds.ToString() + " : " + timespan.Milliseconds.ToString();
        }
        
    }

    public void startTimer()
    {
        timerActive = true;
    }

    public void stopTimer()
    {
        currentTime = 0;
        timerActive = false;
    }
}
