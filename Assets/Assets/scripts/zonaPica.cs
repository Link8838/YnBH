using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zonaPica : MonoBehaviour {

    public Color done;
    public lastChallengeControler lcc;
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "pica") {
            collision.gameObject.GetComponent<Image>().color = done;
            collision.gameObject.GetComponent<controladorSimb>().enabled = false;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            lcc.setPica();
        }
    }

}
