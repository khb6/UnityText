using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTF : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 15f;

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal"); // ����Ƽ�� ���� �� �� �̿�
        float zInput = Input.GetAxis("Vertical");

        float move = zInput * moveSpeed * Time.deltaTime; // ������Ʈ �Լ��� ȣ��� �� �ð����� ��� (�����Ӱ��� ������ �ǹ�)
        float rotate = xInput * rotationSpeed * Time.deltaTime;
        transform.Translate(0, 0, move); // ������Ʈ�� �ٶ󺸰� �ִ¹���(z��)���� �̵� (����Ƽ������ ����� x, z���� ���� ���°� y��)
        transform.Rotate(0, rotate, 0); // y���� �������� ȸ��
    }
}
