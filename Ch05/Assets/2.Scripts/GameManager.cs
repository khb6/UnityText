using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject hpGauge; //�ؿ� hpgauge ���� �Ⱦ��� ���⼭ public �ᵵ �� 
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
