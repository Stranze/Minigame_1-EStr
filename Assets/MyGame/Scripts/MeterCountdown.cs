using UnityEngine;
using TMPro;

public class MeterCountdown : MonoBehaviour
{ 

    public float startTimeInSec = 100.0f;
    public SceneLoader sceneLoader;

    private TextMeshProUGUI timeInSec;
    private float time;
    private float doubleTime = 2.0f;

    private void Start()
    {
        time = startTimeInSec;
        timeInSec = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        time -= Time.deltaTime*doubleTime;
        timeInSec.text = time.ToString("00");

        if (time <= 0.0f)
        {
            sceneLoader.GoodEnd();
        }
    }
}
