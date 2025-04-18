using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speedRatio = 1.0f;
    public float stopSpeed = 0.04f; //퍼블릭 밑에는 프라이빗이고 퍼블릿은 값을 많이 수정할때 좋음
    public float decreaseRate = 0.97f;

    float speed = 0;
    Vector2 startPos;
    Vector2 endPos;
    AudioSource audio;


    bool gameEnded = false;
    bool carStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (gameEnded) return;

        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength * speedRatio /10000.0f;
            audio.Play();
            carStarted = true;
        }

        transform.Translate(speed, 0, 0); //got component 함수 이해하기
        //transform.position += new Vector3(speed, 0, 0);
        //transform.rotation *= Quaternion.Euler(0, 0, speed);

        speed *= decreaseRate;

        if(carStarted && speed < stopSpeed)
        {
            speed = 0f;
            gameEnded = true;
        }
    }
}
