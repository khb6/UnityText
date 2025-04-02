using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManager;

public class GameManager : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
       // car = GameObject.Find("car");
       // flag = GameObject.Find("flag");
       //distance = GameObject.Find("Distance");

    }

    // Update is called once per frame
    void Update()
    {
        if (car == null) return;
        if (flag == null) return;
        if (distance == null) return;

        float length = flag.transform.position.x - car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text 
            = "�Ÿ� : " + length.ToString("F2") + "m";
    }

    public void QuitGame()
    {
        Application .Quit();
    }

    public void ReloadScene()
    {
        string currentScene = SceneManager.GetActiveScene().name; //���� ��Ƽ�� ���ִ� ���� �����ͼ� ��
        SceneManager.LoadScene("currentScene");
        
    }
}
