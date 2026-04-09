using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;              //큐브 이동속도
    void Update()
    {
        transform.Translate(0,0, -moveSpeed * Time.deltaTime);      //z축 마이너스 방향으로 이동

        if (transform.position.z < -20)                     //큐브가 z축 -20이하로 내려 갔는지 확인
        {
            Destroy(gameObject);                        //큐브 자신을 파괴
        }
    }
}
