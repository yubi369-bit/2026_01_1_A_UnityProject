using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int health = 100;        //체력을 선언한다 (변수 정수 표현)
    public float Timer = 1.0f;      //타이머 설정을 한다. (변수 실수 표현)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = health + 100;         //첫 시작할때 100의 체력을 추가 한다.
       
    }

    // Update is called once per frame
    void Update()
    {
        Timer = Timer - Time.deltaTime;
        if (Timer <= 0)             //만약 Timer 의 수치가 0 이하로 내려갉 여우
        {
            Timer = 1.0f;          //다시 1초로 변경 시켜준다.
            health = health - 20;  //체력을 20 감소시킨다.
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health = health + 20;
        }
        if (health <= 0)            //체력이 0이하로 떨어지면
        {
            Destroy(this.gameObject); //이 오브젝트를 파괴한다
        }
    }
}
