using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioZone : MonoBehaviour{

    public AudioSource aus;
    public AudioClip clip;
    public bool played;

    private void OnTriggerEnter(Collider other) {
        if(!played) {
            if(other.gameObject.tag == "Player") {
                aus.PlayOneShot(clip);
                played = true;
            }
        }
    }


}
