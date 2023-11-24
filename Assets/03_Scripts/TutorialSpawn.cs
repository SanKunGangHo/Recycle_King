using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSpawn : MonoBehaviour
{

    public GameObject tutocup;

    public void tutoSpawn()
    {
        // transform.position = new Vector3(0f, 1.6f, -0.8f);
        Instantiate(tutocup, new Vector3(0f, 1.6f, -0.8f), Quaternion.identity);
    }

    public void tutodel()
    {
        GameObject tutocup = GameObject.FindWithTag("PLASTIC");
        // if(gameObject.tag == "PLASTIC")
        // {
        //     Destroy(gameObject);
        // }
        Destroy(tutocup);
    }
}
