using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject hpGauge; //밑에 hpgauge 문장 안쓰고 여기서 public 써도 됨 
    // Start is called before the first frame update
    void Start()
    {
       // hpGauge = GameObject.Find("HP Gauge");
    }

    // Update is called once per frame
    public void DecreaseHP ()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
