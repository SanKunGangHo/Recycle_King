using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    public AudioClip rightBGM; //맞을 때 출력할 브금, 프로젝트의 에셋에서 직접 끌어오면 됨. mp3파일 들어갈 곳이야.
    public AudioClip wrongBGM; //틀렸을 때 출력할 브금

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rightBGM_Setting(){ //맞을 때
        if(audioSource.clip != rightBGM){ //맞은 브금이 아니면 맞은 브금으로 바꿈
            audioSource.clip = rightBGM;
        }
        audioSource.Play();
    }

    public void wrongBGM_Setting(){ //틀릴 때
        if(audioSource.clip != wrongBGM){ //틀린 브금이 아니면 틀린 브금으로 바뀜
            audioSource.clip = wrongBGM;
        }
        audioSource.Play();
    }
}
