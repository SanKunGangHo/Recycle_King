using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_fall : MonoBehaviour
{
    public Vector3 newPosition = new Vector3(-0.823f, 1.1f, -0.307f);

    private void Update() {
        if(transform.position.y < 0.2f){
            gameObject.transform.position = newPosition;
        }    
    }
}
