using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFloor : MonoBehaviour{

    public Light luz;
    public Color green;
    public Color red;
    public Sprite redS, greenS, greenW;
    public bool isRed = true, finish = false;
    public SpriteRenderer sr;
    public BoxCollider bc;

    private void Start() {
        sr = this.GetComponent<SpriteRenderer>();
        luz = this.GetComponent<Light>();
        bc = this.GetComponent<BoxCollider>();
    }

    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            isRed = !isRed;
        }        
    }

    public void FixedUpdate() {
        if(!finish) {
            if(isRed) {
                luz.color = red;
                sr.sprite = redS;
            } else {
                luz.color = green;
                sr.sprite = greenS;
            }
        }
    }

    public bool IsRed() {
        return isRed;
    }

    public void unAbleTile() {
        finish = true;
        sr.sprite = greenW;
        bc.enabled = false;        
    }


}
