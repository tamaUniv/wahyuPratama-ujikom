using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshPro timerText;
    public float timeRemaining;
    public bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning  = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning) {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
    }

    private void DisplayTime(float timeRemaining)
    {
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = seconds.ToString();
    }
}
