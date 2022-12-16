using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour{

    public controlador pc;
    public GeneralTimer gt;
    public AudioSource aus;
    public AudioClip awake;

    public void killObject() {
        Debug.Log("Adios");
        Destroy(this.gameObject);
    }

    public void playAwake() {
        aus.PlayOneShot(awake);
    }

    public void lockPlayer() {
        pc.muteSound();
        pc.enabled = false;
    }

    public void unLockPlayer() {
        pc.enabled = true;
        gt.startTimer();
    }
}
