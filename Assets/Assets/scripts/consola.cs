using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class consola : MonoBehaviour{

    public TextMeshProUGUI texto;
    public string tex, aux, caba;
    public string[] frase, fraseC;
    public int counter, modTimer, cont, numCar;
    public Boolean escribir;
    public GameObject campo;

    // Start is called before the first frame update
    void Start(){
        numCar = 0;
        escribir = false;
        tex = "Esta es una frase que se va a ir imprimiendo con el paso del tiempo, ya no se que mas escribir para que se vea mas texto. APOCALIPSIS, Aqui es donde voy a empezar a escribir un texto para ver como es que se acomoda con el panel y poder ver si puedo escribir historias y escenas dentro de esta madre.";
        campo = GameObject.FindGameObjectWithTag("campo");
    }

    // Update is called once per frame
    void Update(){

        tex = campo.GetComponent<Text>().text;

        if (escribir) {        
            counter++;
            escribirEnTerminal(tex);
        }
    }

    public void escribirEnTerminal(string cadena) {        
        tex = cadena;
        foreach (char c in tex) {
            numCar++;
        }
        string[] frase = new string[numCar];
        numCar = 0;
        foreach (char c in tex) {
            frase[numCar] = Char.ToString(c);
            numCar++;
        }
        fraseC = frase;

        modTimer = counter % 1;
        if (modTimer == 0) {
            if (cont != tex.Length) {
                if (fraseC[cont] != " ") {
                    aux += fraseC[cont];
                } else {
                    aux += " ";
                }
                cont++;
                texto.text = aux;
            } else {
                aux += "\n";
                escribir = false;
                //cont = 0;
                //counter = 0;
                //texto.text = "";                
            }
        }
    }

    public void activarEscritura() {
        escribir = !escribir;
    }

    public void omitir() {
        if (escribir) {
            escribir = false;
            texto.text = tex;
            cont = 0;
        } else {
            if(cont != 0) {
                escribir = false;
                texto.text = tex;
                cont = 0;
            }
        }      
    }

    public void borrar() {
        if (escribir) {
            escribir = false;
            cont = 0;
            texto.text = "";
            aux = "";
        } else {
            cont = 0;
            texto.text = "";
            aux = "";
        }
    }

}
