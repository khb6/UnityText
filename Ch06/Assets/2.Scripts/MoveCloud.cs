using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    float moveSpeed = 0.05f;
    float maxwidth = 1f;

    int direction = 1;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > maxwidth)
        {
            direction = -1;
        }
        if (transform.position.x > -maxwidth)
        {
            direction = 1;
        }
        transform.Translate(moveSpeed*direction, 0, 0);
    }
}
