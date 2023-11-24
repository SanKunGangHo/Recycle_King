using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class uisystem : MonoBehaviour
{
    //public GameObject stopwatchObject; //스탑워치 오브젝트 끌어옴
    public GameObject ObjectOn; //제목 오브젝트 끌어옴
    public GameObject ObjectOff;
    //public AudioSource audioSource;
    //public AudioClip Btnsound;

    //public VideoPlayer videoPlayer; // 테레비 끌어옴

    //private StopWatch stopwatch; //스탑워치 스크립트 저장용

    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        //videoPlayer.Pause();
        //stopwatch = stopwatchObject.GetComponent<StopWatch>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            //stopwatch.StartStopwatch();
            //gameObject.SetActive(false);
            ObjectOff.SetActive(false);
            ObjectOn.SetActive(true);
            //audioSource.PlayOneShot;
            //videoPlayer.Play();
        }
    }
}
