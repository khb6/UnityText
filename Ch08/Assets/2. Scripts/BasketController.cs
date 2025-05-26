using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;


    AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //���콺 ������ ����
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; //������ ������� , 4����Ʈ
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, transform.position.y, z);
            }
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("collision �߻�.");
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Apple") 
            {
            //  Debug.Log("����� ��Ҵ�.");
            aud.PlayOneShot(appleSE);
            }
            else if (other.gameObject.tag == "Bomb")
            {
                //Debug.Log("��ź�� ��Ҵ�.");
                aud.PlayOneShot(bombSE);
        }
        Destroy(other.gameObject);
    }
}
