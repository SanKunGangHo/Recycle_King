using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBox : MonoBehaviour
{
    //public AudioClip soundEffect;
    public AudioSource audioSource;

    private void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag == "TutorialBox")
        {
            audioSource.PlayOneShot(audioSource.clip);
            transform.position = new Vector3(-0.8f, 0.8f, -0.25f);
            
            

            //SoundManager.instance.PlasticSound();
        }
    }
}
