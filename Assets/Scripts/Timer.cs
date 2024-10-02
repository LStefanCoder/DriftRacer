using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //based on https://www.youtube.com/watch?v=hxpUk0qiRGs

    public TMP_Text timerText;
    static public bool timerOn;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn)
        {
            //as long as this script is running, update the time via the built-in deltaTime
            //time += Time.deltaTime;
        }
    }

    void startTimer()
    {
        timerOn = true;
    }

    void endTimer()
    {
        timerOn = false;
    }

    void updateTimer(float time)
    {
        //float mins = Mathf.FloorToInt(time / 60);
        //float secs = Mathf.FloorToInt(time % 60);
    }
}
