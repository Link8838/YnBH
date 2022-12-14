using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour{

    public AudioSource aus;
    public AudioClip grab, ironDoor;
    // Start is called before the first frame update

    public void playGrab() {
        aus.PlayOneShot(grab);
    }

    public void playDoor() {
        aus.PlayOneShot(ironDoor);
    }


}
