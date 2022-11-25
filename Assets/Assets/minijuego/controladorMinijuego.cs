using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{
    Rigidbody2D rb;
    float rotacion;
    float velocidadRotacion = 10f;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown("a")){
            rb.freezeRotation = false;
            rotacion = -45f;
        }else if (Input.GetKeyDown("d")){
            rb.freezeRotation = false;
            rotacion = 45f;
        }else{
            rotacion = 0;
        }
        
        transform.eulerAngles = transform.eulerAngles + (Vector3.forward*rotacion*velocidadRotacion);
    }

    private void FixedUpdate(){
        rb.freezeRotation = true;
    }
}
