using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour{

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<playerStats>().setGas();
        }
        gameObject.SetActive(false);
    }

}
