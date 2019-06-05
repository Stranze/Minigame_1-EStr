using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{ 
    public void LoadSceneMain()
        {
        SceneManager.LoadScene("MainScene");
         }

    public void BadEnd()
    {
        SceneManager.LoadScene("EndScene");
    }
    public void GoodEnd()
    {
        SceneManager.LoadScene("EndScene");
    }
}



