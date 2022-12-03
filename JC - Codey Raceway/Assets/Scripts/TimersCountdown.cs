using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

    public CodeyMove cm;
    float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = cm.Speed;
    }

    // Update is called once per frame
    void Update()
    {
        //totalLapTime -= Time.deltaTime;
        //totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();

        if (totalCountdownTime > 0) 
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            Speed = 0f;
        }

        if (totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime; 
            Speed = 40f;
        }

        if (totalLapTime < 0)
        {
            Debug.Log("Time is Up!");
        }
    }
}