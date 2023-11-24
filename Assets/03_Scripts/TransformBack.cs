using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformBack : MonoBehaviour
{
    public GameObject Player;
    private Vector3 PlayerStartVector3;
    private Quaternion PlayerStartRotation;

    // Start is called before the first frame update
    void Start()
    {
        PlayerStartVector3 = Player.transform.position;
        PlayerStartRotation = Player.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPositionClick(){
        Player.transform.position = PlayerStartVector3;
        Player.transform.rotation = PlayerStartRotation;
    }
}
