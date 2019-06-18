using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeterCountdown : MonoBehaviour { 

    public float startTimeInSec = 100;
    public SceneLoader sceneLoader;

    private TextMeshProUGUI timeInSec;
    private float time;

    private void Start()
    {
        time = startTimeInSec;
        timeInSec = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        time -= Time.deltaTime*2;
        timeInSec.text = time.ToString("00");
        Debug.Log("time: " + time);

        if (time <= 00)
        {
            sceneLoader.GoodEnd();
            Debug.Log("switch");
        }
    }
}
