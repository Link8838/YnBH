using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class challengeOne : MonoBehaviour{

    public GameObject exit;
    public playerStats ps;
    public GameObject inInventory;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            if(ps.getTab()) {
                exit.SetActive(true);
                inInventory.SetActive(false);
            }
        }
    }

}
