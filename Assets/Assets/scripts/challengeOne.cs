using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class challengeOne : MonoBehaviour {

    public GameObject exit;
    public playerStats ps;
    public GameObject inInventory;
    public AudioSource aus;
    public AudioClip clip;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            if(ps.getTab()) {
                aus.PlayOneShot(clip);
                exit.SetActive(true);
                inInventory.SetActive(false);
            }
        }
    }

}
