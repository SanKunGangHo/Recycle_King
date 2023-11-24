using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCounter : MonoBehaviour
{
    public Timer timer;//제한시간 스크립트
    public ResultOutput result; //리절트 결과출력
    public BGMPlayer bgmplayer; //브금 플레이어 SuccesSound로 했음
    public int count;
    public int endCount = 10;
    public int wrongCount;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(count == endCount){ // count가 endCount와 같으면 스탑워치 종료.
            timer.PauseTimer();
            result.GameFin();
        }
    }

    public void CountUp(){//다른 스크립트에서 불림
        count++;
        bgmplayer.rightBGM_Setting();
    }

    public void wrongCountUp(){//다른 스크립트에서 불림
        wrongCount++;
        bgmplayer.wrongBGM_Setting();
    }
}
