using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float duration;
    public Text timerText;
    private float startTime;
    public static float timeRemaining;
    public static bool finish;

    public void Start()
    {
        finish = true;
        timeRemaining = 125.32f;
    }
    private void Update()
    {
        /*
        if(finish)
        {
            timeRemaining += Time.deltaTime * 60;

            if (timeRemaining <= 0)
            {
                // Update timer text
                timerText.text = timeRemaining.ToString("00:00");
            }
        }*/

    }

    public void StartTimer()
    {
        timeRemaining = duration;
    }
}

