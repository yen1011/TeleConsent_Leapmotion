using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // OnTriggerEnter는 다른 Collider와 충돌했을 때 호출됩니다.
    // 충돌한 오브젝트가 "human" 태그를 가지고 있다면 디버그 메시지를 출력합니다.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("human"))
        {
            Debug.Log("Human 오브젝트와 닿았습니다!");
        }
    }
}
