using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class ResultOutput : MonoBehaviour
{
    public Timer timer;//제한시간
    public EndCounter endCounter;//쓰레기 갯수 스크립트
    public TextMeshProUGUI resultText; // 출력할 오브젝트
    public GameObject endSystem;//게임 끝났을 때 출력할 다음 스테이지 가는 UI
    public XRRayInteractor[] xrRayInteractor = new XRRayInteractor[1]; //레이저 들어갈 곳. 양손 넣으면 됨.
    public GameObject Restart, position;//재시작 Canvas 오브젝트
    public TransformBack transformBack;
    public bool GameEnd = false; //게임 끝 bool 값
    public int wrongC; //EndCounter의 endCount값을 가져올 인수값
    private float processingTime;
    private string processedTime;
    private bool isRunning = false;
    private bool timeover = false; 

    void Update()
    {
        if(isRunning == true){
            processingTime += Time.deltaTime;
        }

        if(GameEnd == true){//게임이 끝나면
            transformBack.ResetPositionClick();
            resultOut(); //기록 출력
            xrRayInteractor[0].enabled = true;
            xrRayInteractor[1].enabled = true; //레이저 출력
            wrongC = endCounter.wrongCount;
            if(timeover == false){
                if(wrongC > 2){
                    Restart.SetActive(true);//2개 틀리면 씬 재시작 UI
                }else{
                    endSystem.SetActive(true);//다음 스테이지 UI 액티브 트루
                }
            }else{
                Restart.SetActive(true);
            }
            EndProcessClick();
            GameEnd = false;
        } 
    }

    public void resultOut(){
        resultText.text = "기록 : "+processedTime+" \n"+endCounter.wrongCount.ToString()+"개 틀렸습니다.";
    }

    public void GameFin(){
        GameEnd = true;
    }

    public void StartProcessClick(){
        isRunning = true;
    }
    
    void EndProcessClick(){
        isRunning = false;
        float timeLeftInMinutes = processingTime / 60f;
        // 분과 초를 계산
        int minutes = Mathf.FloorToInt(timeLeftInMinutes);
        int seconds = Mathf.FloorToInt((timeLeftInMinutes - minutes) * 60f);
        // 문자열로 포맷
        string minutesString = minutes.ToString("00");
        string secondsString = seconds.ToString("00");

        // timerText에 문자열을 할당
        processedTime = minutesString + ":" + secondsString;
    }

    public void GameFail(){
        GameEnd = true;
        timeover = true;
    }
}
