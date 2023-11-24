using UnityEngine;
using TMPro;

public class Lefttrash : MonoBehaviour
{
    public TextMeshProUGUI LeftWaste; //출력할 Text(TMP)
    public EndCounter endCounter; //EndCounter
    public int pre_count; //EndCounter에 있는 count의 비교용 이전 변수

    void Update()
    {
        if(endCounter.count != pre_count){ //count가 변했을 때
            pre_count = endCounter.count; //pre_count 갱신
            UpdateChangeCount(); //남은 쓰레기 업데이트
        }
    }

    public void UpdateChangeCount(){
        int left_tr = endCounter.endCount - pre_count; //총 개수에서 count 값을 뺀 갯수를 변수로 저장
        LeftWaste.text = "남은 쓰레기: "+ left_tr +"개"; // 출력
    }
}
