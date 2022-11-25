using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour{

    Rigidbody rb;
    Vector2 inputMov;
    public float velocidadCamina = 10f;
    float rotacion;
    float velocidadRotacion = 10f;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetAxisRaw("Vertical") == 1){
            inputMov.y = Input.GetAxisRaw("Vertical");
        }else{
            inputMov.y = 0;
        }
        if (Input.GetKeyDown("a")){
            rb.freezeRotation = false;
            rotacion = -45f;
        }else if (Input.GetKeyDown("d")){
            rb.freezeRotation = false;
            rotacion = 45f;
        }else{
            rotacion = 0;
        }
        
        transform.eulerAngles = transform.eulerAngles + (Vector3.up*rotacion*velocidadRotacion);
    }

    private void FixedUpdate(){
        float vel = velocidadCamina;
        rb.velocity = transform.forward*vel*inputMov.y;
        rb.freezeRotation = true;
    }
}
