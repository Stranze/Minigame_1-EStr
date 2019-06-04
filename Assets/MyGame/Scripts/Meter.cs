﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Meter : MonoBehaviour { 

public float startTimeInSec = 30;
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
        time -= Time.deltaTime;
        timeInSec.text = time.ToString("00");

        if (time <= 0)
        {
            sceneLoader.LoadGameOverScene();
        }
    }
}
