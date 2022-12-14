using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour{

    public GameObject inInventory;
    public AudioManager am;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            am.playGrab();
            other.gameObject.GetComponent<playerStats>().setKey();
            inInventory.SetActive(true);
        }
        gameObject.SetActive(false);
    }
}
