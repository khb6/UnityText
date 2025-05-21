using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    float power = 0f;
    float start 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate
                (bamsongiPrefab, 
                 transform.position,
                 transform.rotation);

            // bamsongi.transform.position = new Vector3
            //     (transform.position.x,
            //      transform.position.y + 1,
            //    transform.position.z + 1);
            bamsongi.transform.position = transform.position + transform.forward; //전방의 충돌이 안 일어나게 코드 수정
                

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Vector3 worldDir = ray.direction;

            //bamsongi.GetComponent<BamsongiController>().Shoot(new Vector3(0, 200, 2000));
            bamsongi.GetComponent<BamsongiController>().Shoot(worldDir * 2000);
            shoot((transform.forward = transform.up)  normalized * power * 2000);
        }
    }
}