using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class challengeThree : MonoBehaviour{

    public GameObject exit;
    public playerStats ps;
    public GameObject inInventory;
    public AudioManager am;

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Player") {
            if(ps.getKey()) {
                am.playDoor();
                inInventory.SetActive(false);
                exit.SetActive(false);
            }
        }
    }
}
