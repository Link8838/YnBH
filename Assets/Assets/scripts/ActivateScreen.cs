using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateScreen : MonoBehaviour{

    public GameObject minigame, water, player;
    public SpriteRenderer computerScreen;
    public Sprite onScreen;
    public Sprite offScreen;
    public Sprite offScreenWin;
    public Light computerLigth;
    public controlador pc;
    public countDown cd;
    public SendToSpawnPoint sts;
    Coroutine rutina;
    public float time = 60;
    public bool startGame = false;
    public AudioSource aus;
    public AudioClip clip;

    private void OnTriggerEnter(Collider other) {
        if(!startGame) {
            startGame = true;
            corutinaCtrl(1);
        }
    }

    public void EnableScreen() {
        aus.Play();
        pc.muteSound();
        pc.enabled = false;
        minigame.SetActive(true);
        computerLigth.intensity = computerLigth.intensity / 2;
        cd.startTimer();
    }

    public void DisableScreen() {
        minigame.SetActive(false);
        computerLigth.enabled = false;
        pc.enabled = true;
    }

    public void offChallenge() {
        corutinaCtrl(2);
        computerScreen.sprite = offScreen;
        startGame = false;
        cd.resetTimer();
        sts.stsp(player);
        computerLigth.enabled = true;
        computerLigth.intensity = computerLigth.intensity*2;
        computerScreen.sprite = onScreen;
    }

    public void challengePassed() {
        corutinaCtrl(2);
        water.SetActive(true);
        computerScreen.sprite = offScreenWin;
        aus.PlayOneShot(clip);
    }

    public IEnumerator StartMinigame() {
        EnableScreen();
        yield return new WaitForSecondsRealtime(time);
        DisableScreen();
    }

    public IEnumerator FinishMinigame() {
        DisableScreen();
        yield return new WaitForSeconds(0.5f);
    }

    //Controlador de las corrutinas para llamadas limpias.
    public void corutinaCtrl(int type) {
        if(rutina != null) {
            StopAllCoroutines();
        }
        switch(type) {
            case 1:
                rutina = StartCoroutine(StartMinigame());
                break;
            case 2:
                rutina = StartCoroutine(FinishMinigame());
                break;
        }        
    }
}
