using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoockPlayer : MonoBehaviour{

    public GameObject puerta;
    public GameObject llave;
    public bool start = false;

    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            if(!start) {
                lockPlayer();
                start = true;
            }            
        }
    }

    public void lockPlayer() {
        puerta.SetActive(true);
    }

    public void unLoockPlayer() {
        puerta.SetActive(false);
        llave.SetActive(true);
    }
}
