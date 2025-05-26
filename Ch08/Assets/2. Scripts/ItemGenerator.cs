using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;

    float span = 1f;
    float delta = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if (delta > span)
        {
            Instantiate(applePrefab, transform.position, transform.rotation);
            delta = 0;
        }
    }
}
