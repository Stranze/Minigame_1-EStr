﻿using UnityEngine;
using TMPro;

public class TimeCountdown : MonoBehaviour {

    public float startTimeInSec = 60;
    public SceneLoader sceneLoader;

    private TextMeshProUGUI Timer;
    private float time;

    private void Start()
    {
        time = startTimeInSec;
        Timer = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        time -= Time.deltaTime;
        Timer.text = time.ToString("00");

        if (time <= 0)
        {
            sceneLoader.BadEnd();
        }
    }
}
