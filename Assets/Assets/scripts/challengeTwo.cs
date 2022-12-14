using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class challengeTwo : MonoBehaviour{

    public GameObject exit;
    public playerStats ps;
    public GameObject gasInventory;
    public GameObject waterInvetory;
    public AudioSource aus;
    public AudioClip clip;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            if(ps.getWater()) {
                aus.PlayOneShot(clip);
                exit.SetActive(false);
                waterInvetory.SetActive(false);
                ps.setWater();
            }
            if(ps.getGas()) {
                gasInventory.SetActive(false);
                ps.setGas();
            }
        }
    }
}
