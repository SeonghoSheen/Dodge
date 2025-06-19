using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        GameObject gg = GameObject.Find("Player");
        Transform tt = transform;

    }

    // Update is called once per frame
    private void Update()
    {
        //수평축과 추직축을 float형 변수에 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
                
        //저장된 변수를 실제속도로 변환
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        //float xSpeed = Mathf.FloorToInt(xInput * speed);
        //float zSpeed = Mathf.FloorToInt(zInput * speed);


        //Vector3 변환
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //리지드바디의 속도 할당
        playerRigidbody.linearVelocity = newVelocity;

        // playerRigidbody.AddForce(xInput * speed, 0f, zInput * speed);
        Debug.Log("X축 입력" + xInput);
        Debug.Log("Z축 입력" + zInput);


        /* AddForce Method
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //위쪽 방향키 입력이 감지된 경우 z 방향 힘주기
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            //아래쪽 방향키 입력이 감지된 경우  -z 방향 힘주기
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            //아래쪽 방향키 입력이 감지된 경우 x 방향 힘주기
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //아래쪽 방향키 입력이 감지된 경우 -x 방향 힘주기
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        */
    }
}