using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablon : MonoBehaviour{

    public GameObject inInventory;
    public AudioManager am;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            am.playGrab();
            other.gameObject.GetComponent<playerStats>().setTab();
            inInventory.SetActive(true);
        }
        gameObject.SetActive(false);
    }

}
