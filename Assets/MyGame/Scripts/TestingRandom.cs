using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestingRandom : MonoBehaviour {

    public float minValX = -6f;
    public float maxValX = 6f;
    private float rndVal;
    private float rndVal2;

    private System.Random rndVal1 = new System.Random();

    // Use this for initialization
    void Start () {
        rndVal = rndVal1.Next(-6, 7);
        rndVal2 = UnityEngine.Random.Range(4, 100);
        Debug.Log(rndVal);
        Debug.Log(rndVal2);
        gameObject.transform.position = new Vector3(rndVal, 0f, 0f);
	}

    public void ChangeRandomCollectable()
    {
        gameObject.transform.position = new Vector3(rndVal, 0f, 0f);
    }



    // Update is called once per frame
    void Update () {
		
	}
}
