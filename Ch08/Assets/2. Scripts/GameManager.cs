using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject timerText;
    public GameObject PointText;

    ItemGenerator generator;

    int point = 0;
    float time = 30.0f;
    //// Start is called before the first frame update
    void Start()
    {
        //timerText = GameObject.Find("Time");
        generator = GameObject.Find("ItemGenerator").GetComponent<ItemGenerator>();
    }

    public void GetApple ()
    {
        point += 100;
    }

    public void GetBomb()
    {
        point /= 2;

    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0)
        {
            time = 0;
            generator.SetParameters(10000f, 0, 0);
        }
        else if (0 <=time && time < 5)
        {
            generator.SetParameters(0.9f, -0.04f, 0.3f);
        }
        else if (5 <= time && time < 10)
        {
            generator.SetParameters(0.4f, -0.06f, 0.6f);
        }
        else if (10 <= time  && time < 20)
        {
            generator.SetParameters(0.7f, -0.04f, 0.4f);
        }
        else if (20 <= time  && time < 30)
        {
            generator.SetParameters(1.0f, -0.03f, 0.2f);
        }

        timerText.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
        PointText.GetComponent<TextMeshProUGUI>().text = point.ToString() + " Point";
    }
}
