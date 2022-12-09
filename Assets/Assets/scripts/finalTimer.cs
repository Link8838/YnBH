using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class finalTimer : MonoBehaviour {

    public float timeleft;
    public bool timerOn = false;
    public lastChallengeControler lcc;

    public TMP_Text text;

    // Update is called once per frame
    void Update() {
        if(timerOn) {
            if(timeleft > 0) {
                timeleft -= Time.deltaTime;
                updateTimer(timeleft);
            } else {
                timeleft = 0;
                timerOn = false;
                resetTimer();
                lcc.challegeFaield();                
            }
        }
    }

    public void updateTimer(float currentTime) {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        text.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public void startTimer() {
        timerOn = true;
    }

    public void resetTimer() {
        timeleft = 45.0f;
    }
}
