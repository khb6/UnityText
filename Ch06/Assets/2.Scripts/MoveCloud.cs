using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float avgSpeed = 0.05f;
    float range = 0.02f;
    float maxWidth = 10f;

    public float movespeed;

    int direction = 1;

    private void Start()
    {
        movespeed = avgSpeed;
    }

    void Update()
    {
        if (transform.position.x > maxWidth)
        {
            direction = -1;
            movespeed = Random.Range(avgSpeed - range, avgSpeed + range);
        }
        else if (transform.position.x < -maxWidth)
        {
            direction = 1;
            movespeed = Random.Range(avgSpeed - range, avgSpeed + range);
        }
        transform.Translate(movespeed * direction, 0, 0);
    }
}


//오늘 업데이트 내역 (태그, 구름 속도 변화, 부모자식 스케일 변화 조절)
