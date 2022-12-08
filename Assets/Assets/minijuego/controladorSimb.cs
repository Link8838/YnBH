using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorSimb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            //transform.Translate(-0.002f,0,0);
            transform.position = transform.position + new Vector3(-0.002f,0,0); 
        }else if(Input.GetKey(KeyCode.D)){
            //transform.Translate(0.002f,0,0);
            transform.position = transform.position + new Vector3(0.002f,0,0);
        }else if(Input.GetKey(KeyCode.W)){
            //transform.Translate(0,0.002f,0);
            transform.position = transform.position + new Vector3(0,0.002f,0);
        }else if(Input.GetKey(KeyCode.S)){
            //transform.Translate(0,-0.002f,0);
            transform.position = transform.position + new Vector3(0,-0.002f,0);
        }
    }
}
