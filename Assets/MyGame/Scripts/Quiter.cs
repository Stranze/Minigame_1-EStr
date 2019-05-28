using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiter : MonoBehaviour {

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("exit");
    }

}
