using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    // Update is called once per frame
   /* 
    * void Update()
    {
   //     if(Input.GetMouseButton(0))
   //     {
    //        SceneManager.LoadScene("GameScene 1");
   //     }
    }
   */

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayGame ()
    {
    SceneManager.LoadScene("GameScene 1");
    }
}
