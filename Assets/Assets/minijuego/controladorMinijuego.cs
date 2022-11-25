using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorMinijuego : MonoBehaviour{

    float rotacion;
    float velocidadRotacion = 10f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown("a")){
            rotacion = -45f;
        }else if (Input.GetKeyDown("d")){
            rotacion = 45f;
        }else{
            rotacion = 0;
        }
        
        transform.eulerAngles = transform.eulerAngles + (Vector3.forward*rotacion*velocidadRotacion);
    }
}
