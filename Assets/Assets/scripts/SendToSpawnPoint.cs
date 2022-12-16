using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendToSpawnPoint : MonoBehaviour{

    public Transform spawnPoint;
    public EndGame eg;
    public AudioSource aus;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            stsp(other.gameObject);
        }
    }

    public void stsp(GameObject player) {
        aus.Play();
        eg.addDead();
        player.transform.position = spawnPoint.position;
        player.gameObject.transform.rotation = spawnPoint.rotation;
    }

}
