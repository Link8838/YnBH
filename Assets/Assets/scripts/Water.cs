using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour{

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<playerStats>().setWater();
        }
        gameObject.SetActive(false);
    }

}
