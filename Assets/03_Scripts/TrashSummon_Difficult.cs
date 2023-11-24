using UnityEngine;

public class TrashSummon_Difficult : MonoBehaviour
{
    public GameObject parentTrash;//부모 오브젝트
    public GameObject[] childTrash;// 자식 오브젝트들
    private GameObject[] currentChild; //이미 소환된 오브젝트
    public int forHow;

    void Start()
    {
        childTrash = GetChildrenArray(parentTrash);
        currentChild = new GameObject[forHow];
        Setting_Game();
    }
    
    //부모 오브젝트를 지정하여 자식 오브젝트들을 모두 배열화
    public GameObject[] GetChildrenArray(GameObject parentTrash){
        int childCount = parentTrash.transform.childCount; //자식 오브젝트 수 구하기
        GameObject[] childTrash = new GameObject[childCount]; //자식 오브젝트 저장할 배열 생성
        for(int i = 0; i<childCount; i++) //배열에 저장
        {
            childTrash[i] = parentTrash.transform.GetChild(i).gameObject;
        }
        return childTrash; //반환
    }

    public void ActiveRandomChildWithTag(GameObject parentTrash){
        // 부모 오브젝트의 자식 오브젝트들을 배열
        GameObject[] childTrash = GetChildrenArray(parentTrash);

        // 랜덤하게 하나를 선택하여 활성화
        GameObject newChild = null;
        do{
            int randomIndex = UnityEngine.Random.Range(0, childTrash.Length);
            if(randomIndex >= childTrash.Length){
                continue;
            }
            newChild = childTrash[randomIndex];
        }while(IsChildActive(newChild, currentChild));//이전에 소환한 게임오브젝트가 맞으면 다시 돌림

        newChild.SetActive(true);//소환
        UpdateCurrentChild(newChild);
    }

    private void UpdateCurrentChild(GameObject newChild){

        // 현재 쓰레기 배열에서 null인 요소에 새로운 쓰레기 추가
        for(int i = 0; i < currentChild.Length; i++) {
            if(currentChild[i] == null) {
                currentChild[i] = newChild;
                return;
            }
        }
        // 현재 쓰레기 배열이 모두 차 있는 경우, 첫 번째 요소를 대체
        currentChild[0] = newChild;
    }

    private bool IsChildActive(GameObject child, GameObject[] activeChildren){
        // 현재 자식 중에 이미 활성화된 자식이 있는지 확인하는 메서드
        if(activeChildren == null){
            return false;
        }

        for(int i = 0; i < activeChildren.Length; i++) {
            if(activeChildren[i] != null && activeChildren[i].activeSelf) {
                if(activeChildren[i] == child) {
                    return true;
                }
            }
        }
        return false;
    }

    void Setting_Game(){ //자식 오브젝트를 랜덤으로 활성화함
        for(int i = 0; i < forHow; i++){
            ActiveRandomChildWithTag(parentTrash);
        }
    }
}
