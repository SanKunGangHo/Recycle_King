using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage_Scene : MonoBehaviour
{
    public int SceneNum;

    public void Start(){
        SceneNum = SceneManager.GetActiveScene().buildIndex;
    }

    public void NextClick(){
        if(SceneNum+1 == 3){
            SceneManager.LoadScene(0);
        }
        SceneManager.LoadScene(SceneNum+1);
    }

    public void RestartScene(){
        SceneManager.LoadScene(SceneNum);
    }
    
    public void BackToFirst(){
        SceneManager.LoadScene(0);
    }

    public void BackToSecond(){
        SceneManager.LoadScene(1);
    }

    public void BackToThird(){
        SceneManager.LoadScene(2);
    }
}
