using UnityEngine;

public class TrashSummon : MonoBehaviour
{
    public GameObject parentTrash, currentChild;
   
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
        GameObject newChild;
        do{
            int randomIndex = UnityEngine.Random.Range(0, childTrash.Length);
            newChild = childTrash[randomIndex];
        }while(currentChild == newChild);//이전에 소환한 게임오브젝트가 맞으면 다시 돌림
        currentChild = newChild;

        newChild.SetActive(true);//소환
    }
}
