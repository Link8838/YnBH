using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class EndGame : MonoBehaviour{

    public GeneralTimer gt;
    public Animator anim;
    public GameObject title,mg,boton;
    public TMP_Text box;
    public AudioSource aus;
    public controlador pc;
    public string time;
    public float timer;
    public bool start, finish, risk;
    public string text = "S#jeto de pru%bas n-mero: <$_!>\n\nTi|mpo de ejecuci=n: ";
    public string tex, aux, caba;
    public string[] frase, fraseC;
    public int counter, modTimer, cont, numCar;  
    private void OnTriggerEnter(Collider other) {
        pc.muteSound();
        pc.enabled = false;
        anim.SetTrigger("ligth");
        timer = gt.endTimer();
        time = gt.timerText();
        preprareText();
        title.SetActive(true);
        boton.SetActive(true);
        box.gameObject.SetActive(true);
    }

    private void FixedUpdate() {
        if(start) {
            timer++;
            escribir(text);
        }
    }

    void preprareText() {
        text = "S#jeto de pru%bas n-mero: <$_!>\n\nTi|mpo de ejecuci=n: ";
        text += time;
        buildText();
        Debug.Log(text);
        start = true;
    }

    void buildText() {
        string na = "\n\nNivel de amenaza: ";
        if(timer <= 90.0f) {
            na += "Alta\n\nEl sujeto super$ las expectativas y es conciderado de importancia biol%gica, mantener en enci=rro y evitar cualquier contacto con el exterior.";
            risk = true;
        } else if(timer > 90.0f && timer <= 240.0f) {
            na += "Moderado\n\nEl sujeto pose| habilidades encima del promed%o, mantener en observaci=n.";
        } else if(timer > 240.0f && timer <= 600.0f) {
            na += "Leve\n\nEl suj#to no posee habilidades sufucientes para ser un r?esgo.";
        } else if(timer > 600.0f) {
            na += "Nulo\n\nSe determin0 que el sujeto no posee las caracter|sticas para ser conciderado AmEnaz@.";
        }
        text += na;
    }

    public void escribir(string cadena) {
        tex = cadena;
        foreach(char c in tex) {
            numCar++;
        }
        string[] frase = new string[numCar];
        numCar = 0;
        foreach(char c in tex) {
            frase[numCar] = Char.ToString(c);
            numCar++;
        }
        fraseC = frase;

        modTimer = counter % 3;
        if(modTimer == 0) {
            if(cont != tex.Length) {
                if(fraseC[cont] != " ") {
                    aux += fraseC[cont];
                } else {
                    aux += " ";
                }
                cont++;
                box.text = aux;
                if(!aus.isPlaying) {
                    aus.Play();
                }
            } else {
                aux += "\n";
                start = false;
                if(risk) {
                    mg.SetActive(true);
                }
                aus.Stop();
            }
        }
    }

}
