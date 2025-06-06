using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0) 
        {
            animator.SetTrigger("JumpTrigger");
            rigid2D.AddForce(transform.up * jumpForce); //vector 보다 up이 가독성이 더 좋음
            //rigid2D.AddForce(new Vector2(0,1) * jumpForce);
            
        }

        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedX = Mathf.Abs(rigid2D.velocity.x); //누르면 속도 더하기

        if (speedX < maxWalkSpeed) // 맥스 스피드로 속도 조절
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if (rigid2D.velocity.y == 0)
        {
            animator.speed = speedX / 2.0f;

        }
        else
        {
            animator.speed = 1.0f;
        }

        animator.speed = speedX / 2.0f;

        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("GameSceneMove");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug("goal");
        SceneManager.LoadScene("ClearScene");
    }
     
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Cloud") return;
        transform.SetParent(collision.gameObject.transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Cloud") return;
        transform.SetParent(null);
    }

}
