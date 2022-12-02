using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discoChallenge : MonoBehaviour{

    GameObject[] tiles;
    public LoockPlayer lp;
    public bool finish;

    // Start is called before the first frame update
    void Start(){
        tiles = GameObject.FindGameObjectsWithTag("Tile");
    }

    // Update is called once per frame
    void Update(){
        if(checkIfComplete()) {
            lp.unLoockPlayer();
            unableAll();
            Destroy(this);
        }
    }

    public bool checkIfComplete() {
        finish = true;
        foreach(GameObject ob in tiles){
            if(ob.GetComponent<TileFloor>().IsRed()) {
                finish = false;
                break;
            }
        }
        return finish;
    }

    public void unableAll() {
        foreach(GameObject ob in tiles) {
            ob.GetComponent<TileFloor>().unAbleTile();
        }
    }


}
