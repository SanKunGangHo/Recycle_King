using UnityEngine;

public class TrashTagChecker : MonoBehaviour
{
    public Timer timer;
    public EndCounter endCounter;

    void OnCollisionEnter(Collision col)
    {
        //충돌하는 콜라이더가 이 오브젝트와 같은 태그일 때와 다른 태그일 때를 나누는 메소드
        string tag = col.gameObject.tag;
        if (col.gameObject.CompareTag(gameObject.tag))
        {
            Destroy(col.gameObject);
            endCounter.CountUp();
        }
        else if(!col.gameObject.CompareTag(gameObject.tag))
        {
            if(tag == "Plastic"||tag == "Normal"||tag == "Can"||
                tag == "Pet"||tag == "Glass"||tag == "Vinyl"||tag == "Paper")
            { 
                timer.Penalty_time();
                endCounter.CountUp();
                endCounter.wrongCountUp();
                Destroy(col.gameObject);
            }
        }
    }
}
