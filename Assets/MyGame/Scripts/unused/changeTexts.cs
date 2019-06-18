using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class changeTexts : MonoBehaviour {

    public Text myText; 
    public TextMeshProUGUI myTMPText;
    public TestingRandom myScript;

    private int countPresses = 0;


    private System.Random rnd = new System.Random();
    private System.Random seedRnd = new System.Random(123);

    // Use this for initialization
    void Start () {
        myText.text = "Hallo";
        myTMPText.text = "meh";
        myText.fontSize = 30;
        Debug.Log(rnd.Next(0, 5));
        Debug.Log("yep " + UnityEngine.Random.Range(0, 1));
    }
	
    public void addPress()
    {
        //machen das gleiche
        countPresses++;
        //countPresses = countPresses + 1;
        //countPresses += 1;
        Debug.Log("counts: " + countPresses);
        myText.text = countPresses.ToString();
        Debug.Log("seed " + seedRnd.Next(0, 5));
        myScript.ChangeRandomCollectable();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
