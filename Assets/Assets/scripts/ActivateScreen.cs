using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateScreen : MonoBehaviour{

    public GameObject minigame;
    public SpriteRenderer computerScreen;
    public Sprite offScreen;
    public Light computerLigth;
    public controlador pc;
    Coroutine rutina;
    public float time = 60;
    public bool startGame = false;

    private void OnTriggerEnter(Collider other) {
        if(!startGame) {
            startGame = true;
            corutinaCtrl(time);
        }
    }

    public void EnableScreen() {
        pc.enabled = false;
        minigame.SetActive(true);
        computerLigth.intensity = computerLigth.intensity / 2;
    }

    public void DisableScreen() {
        minigame.SetActive(false);
        computerScreen.sprite = offScreen;
        computerLigth.enabled = false;
        pc.enabled = true;
    }

    public IEnumerator StartMinigame(float time) {
        EnableScreen();
        yield return new WaitForSecondsRealtime(time);
        DisableScreen();
    }

    //Controlador de las corrutinas para llamadas limpias.
    public void corutinaCtrl(float time) {
        if(rutina != null) {
            StopAllCoroutines();
        }
        rutina = StartCoroutine(StartMinigame(time));
    }
}
