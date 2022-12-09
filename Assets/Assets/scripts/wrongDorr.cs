using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrongDorr : MonoBehaviour{

    public SendToSpawnPoint ssp;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            ssp.stsp(other.gameObject);
        }
    }

}
