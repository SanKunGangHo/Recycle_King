using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
   public void RecordScene(){
    //SceneManager.LoadScene("Record_Game");
   }

   public void TitleScene(){
    SceneManager.LoadScene("01_Title");
   }
}
