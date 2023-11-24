using UnityEngine;

public class Summoner : MonoBehaviour
{
    public GameObject parentTrash;//소환할 오브젝트들의 부모 오브젝트
    public int forHow; //반복할 숫자

    void Start()
    {
        Setting_Game(); //활성화할 때 메서드
    }

    void Setting_Game(){ //자식 오브젝트를 랜덤으로 활성화함
        TrashSummon trashSummon = GetComponent<TrashSummon>();
        for(int i = 0; i < forHow; i++){
            trashSummon.ActiveRandomChildWithTag(parentTrash);
        }
    }
}
