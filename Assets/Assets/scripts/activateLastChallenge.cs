using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activateLastChallenge : MonoBehaviour {

    public GameObject minigame, player;
    public SpriteRenderer computerScreen;
    public Light computerLigth;
    public controlador pc;
    public finalTimer cd;
    public SendToSpawnPoint sts;
    public float time = 60;
    public bool startGame = false;
    public AudioSource aus;

    private void OnTriggerEnter(Collider other) {
        EnableScreen();
    }

    public void EnableScreen() {
        aus.Play();
        pc.muteSound();
        pc.enabled = false;
        minigame.SetActive(true);
        computerLigth.intensity = computerLigth.intensity / 2;        
    }
}
