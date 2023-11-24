using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WatchStarter : MonoBehaviour
{
    //public StopWatch stopwatchObject; //스탑워치 오브젝트 끌어옴
    public Timer timer;//제한시간 오브젝트 끌어옴
    public GameObject TitleObject; //제목 오브젝트 끌어옴

    //public VideoPlayer videoPlayer; // 테레비 끌어옴

    // Start is called before the first frame update
    void Start()
    {
        //videoPlayer.Pause();
        //stopwatch = stopwatchObject.GetComponent<StopWatch>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            Invoke("WatchStart",3f);
        }
    }

    void WatchStart(){
        timer.startTimerClick();
        gameObject.SetActive(false);
        TitleObject.SetActive(false);
        //videoPlayer.Play();
    }
}
