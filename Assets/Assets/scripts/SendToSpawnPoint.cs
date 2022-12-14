using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendToSpawnPoint : MonoBehaviour{

    public Transform spawnPoint;
    public AudioSource aus;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            stsp(other.gameObject);
        }
    }

    public void stsp(GameObject player) {
        aus.Play();
        player.transform.position = spawnPoint.position;
        player.gameObject.transform.rotation = spawnPoint.rotation;
    }

}
