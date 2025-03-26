using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTest : MonoBehaviour
{
    float speed = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);   //트랜스레이트 좌표계는 다르다 로컬 좌표계는 모델 자체가 가지고 있는 좌표로 쓴다.
        //transform.position += new Vector3(speed, 0, 0);
    }
}
