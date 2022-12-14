using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GeneralTimer : MonoBehaviour {

    public float timeleft;
    public bool timerOn = false;
    public string time;
    public TMP_Text text;

    // Update is called once per frame
    void Update() {
        if(timerOn) {
            timeleft += Time.deltaTime;
            updateTimer(timeleft);
        }
    }

    public void updateTimer(float currentTime) {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        time = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public void startTimer() {
        timerOn = true;
    }

    public float endTimer() {
        timerOn = false;
        return timeleft;
    }

    public string timerText() {
        return time;
    }

}
