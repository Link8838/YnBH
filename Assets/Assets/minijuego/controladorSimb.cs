using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorSimb : MonoBehaviour{

    public float move;
    public AudioSource aus;
    public AudioClip bit;

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(KeyCode.A)){
            aus.PlayOneShot(bit);
            transform.position = transform.position + new Vector3(-move,0,0); 
        }else if(Input.GetKey(KeyCode.D)){
            aus.PlayOneShot(bit);
            transform.position = transform.position + new Vector3(move,0,0);
        }else if(Input.GetKey(KeyCode.W)){
            aus.PlayOneShot(bit);
            transform.position = transform.position + new Vector3(0,move,0);
        }else if(Input.GetKey(KeyCode.S)){
            aus.PlayOneShot(bit);
            transform.position = transform.position + new Vector3(0,-move,0);
        }
    }
}
