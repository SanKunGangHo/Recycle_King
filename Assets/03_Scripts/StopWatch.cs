using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class StopWatch : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float elapsedTime;
    public bool isRunning = false;

    void Start()
    {
        Stage_Next();
    }

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerText();
        }
    }

    public void StartStopwatch()
    {
        isRunning=true;
    }

    public void PauseStopwatch()
    {
        isRunning = false;
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        int milliseconds = Mathf.FloorToInt((elapsedTime - Mathf.Floor(elapsedTime)) * 1000f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void AddTime(float secondsToAdd){
        if(!isRunning){
            return;
        }

        elapsedTime += secondsToAdd;
        UpdateTimerText();
        //10초 패널티
    }

    public void Stage_Next(){
        elapsedTime = 0;
    }


}