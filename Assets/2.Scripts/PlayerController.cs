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
        //������� �������� float�� ������ ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
                
        //����� ������ �����ӵ��� ��ȯ
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        //float xSpeed = Mathf.FloorToInt(xInput * speed);
        //float zSpeed = Mathf.FloorToInt(zInput * speed);


        //Vector3 ��ȯ
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        //������ٵ��� �ӵ� �Ҵ�
        playerRigidbody.linearVelocity = newVelocity;

        // playerRigidbody.AddForce(xInput * speed, 0f, zInput * speed);
        Debug.Log("X�� �Է�" + xInput);
        Debug.Log("Z�� �Է�" + zInput);


        /* AddForce Method
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //���� ����Ű �Է��� ������ ��� z ���� ���ֱ�
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            //�Ʒ��� ����Ű �Է��� ������ ���  -z ���� ���ֱ�
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            //�Ʒ��� ����Ű �Է��� ������ ��� x ���� ���ֱ�
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //�Ʒ��� ����Ű �Է��� ������ ��� -x ���� ���ֱ�
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        */
    }
}