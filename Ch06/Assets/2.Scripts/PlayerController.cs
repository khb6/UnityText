using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    public float jumpForce = 300f;
    public float walkForce = 10f;
    float maxWalkSpeed = 2f;

    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rigid2D.AddForce(transform.up * jumpForce); //vector ���� up�� �������� �� ����
            //rigid2D.AddForce(new Vector2(0,1) * jumpForce);
            
        }

        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedX = Mathf.Abs(rigid2D.velocity.x); //������ �ӵ� ���ϱ�

        if (speedX < maxWalkSpeed) // �ƽ� ���ǵ�� �ӵ� ����
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        animator.speed = speedX / 2.0f;
    }
}
