using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniGamePassed : MonoBehaviour{

    // Start is called before the first frame update
    public ActivateScreen offScreen;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "waterP") {
            offScreen.challengePassed();
        }
    }
}
