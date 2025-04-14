using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float span = 1.0f; //생성 주기 public으로 조정
    float delta = 0f;

    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-8, 9); //6은 나오지만 7은 안됨
            go.transform.position = new Vector3(px, 6, 0);

            delta = 0;
        }
    }
}
