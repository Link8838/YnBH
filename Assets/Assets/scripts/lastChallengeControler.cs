using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastChallengeControler : MonoBehaviour{

    public bool pica, cora, diam;
    public GameObject miniGame, wall, player, door;
    public SendToSpawnPoint ssp;
    public finalTimer ft;
    public AudioSource aus;
    public AudioClip win;

    // Update is called once per frame
    void Update(){
        if(pica && cora && diam) {
            challengePassed();
        }
    }

    public void setPica() {
        pica = true;
    }
    public void setDiam() {
        diam = true;
    }
    public void setCora() {
        cora = true;
    }

    public void challengePassed() {
        aus.PlayOneShot(win);
        wall.SetActive(false);
        door.SetActive(false);
        miniGame.SetActive(false);
        player.GetComponent<controlador>().enabled = true;
    }

    public void challegeFaield() {
        ft.resetTimer();
        ssp.stsp(player);
        miniGame.SetActive(false);
        player.GetComponent<controlador>().enabled = true;
    }
}
