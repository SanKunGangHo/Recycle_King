using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLimit = 180f, timeLeft;   // 제한 시간 (초), 남은 시간
    public TextMeshProUGUI timerText;   // 타이머를 표시할 Text(TMP)파일
    private bool isRunning;
    public ResultOutput result; // ResultOutput.cs를 포함한 오브젝트 끌어옴

    private void Start()
    {
        // 시작할 때 남은 시간을 초기화한다.
        timeLeft = timeLimit;
    }

    private void Update()
    {
        if(isRunning)
        {
            timeLeft -= Time.deltaTime;
            UpdateTimerUI();
        }// 남은 시간이 0보다 작거나 같으면 게임 오버
        if (timeLeft <= 0f)
        {
            // 게임 오버
            GameOver();
            return;
        }
    }

    public void startTimerClick(){
        isRunning = true; 
    }//게임시작

    public void PauseTimer(){
        isRunning = false;
    }//게임 종료

    private void UpdateTimerUI()
    {
        float timeLeftInMinutes = timeLeft / 60f;
        int minutes = Mathf.FloorToInt(timeLeftInMinutes);
        int seconds = Mathf.FloorToInt((timeLeftInMinutes - minutes) * 60f);
        string minutesString = minutes.ToString("00");
        string secondsString = seconds.ToString("00");
        timerText.text = minutesString + ":" + secondsString;
        //UI에 시간을 실시간으로 업데이트
    }

    public void Penalty_time(){ //페널티 적용
        timeLeft -= 10f;
    }

    private void GameOver()
    {
        result.GameFail();
        PauseTimer();
    }

}
