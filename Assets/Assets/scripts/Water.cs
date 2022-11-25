using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour{

    public GameObject inInventory;
    public GameObject gasInvertory;
    public GameObject gas;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            if(other.gameObject.GetComponent<playerStats>().getGas()) {
                gasInvertory.SetActive(false);
                gas.SetActive(true);
                other.gameObject.GetComponent<playerStats>().setGas();
            }
            other.gameObject.GetComponent<playerStats>().setWater();
            inInventory.SetActive(true);
        }
        gameObject.SetActive(false);
    }

}
