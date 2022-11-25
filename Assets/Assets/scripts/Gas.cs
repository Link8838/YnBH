using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour{

    public GameObject inInventory;
    public GameObject waterInvertory;
    public GameObject water;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            if(other.gameObject.GetComponent<playerStats>().getWater()) {
                waterInvertory.SetActive(false);
                water.SetActive(true);
                other.gameObject.GetComponent<playerStats>().setWater();
            }
            other.gameObject.GetComponent<playerStats>().setGas();
            inInventory.SetActive(true);
        }
        gameObject.SetActive(false);
    }

}
