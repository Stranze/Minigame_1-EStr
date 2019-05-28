using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiter : MonoBehaviour {

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("esxit");
    }

}
