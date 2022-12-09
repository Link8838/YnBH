using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorSimb : MonoBehaviour{

    public float move;

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(KeyCode.A)){
            transform.position = transform.position + new Vector3(-move,0,0); 
        }else if(Input.GetKey(KeyCode.D)){
            transform.position = transform.position + new Vector3(move,0,0);
        }else if(Input.GetKey(KeyCode.W)){
            transform.position = transform.position + new Vector3(0,move,0);
        }else if(Input.GetKey(KeyCode.S)){
            transform.position = transform.position + new Vector3(0,-move,0);
        }
    }
}
