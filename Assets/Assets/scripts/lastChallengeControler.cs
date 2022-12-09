using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastChallengeControler : MonoBehaviour{

    public bool pica, cora, diam;
    public GameObject miniGame, wall, player;
    public SendToSpawnPoint ssp;

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
        wall.SetActive(false);
        miniGame.SetActive(false);
        player.GetComponent<controlador>().enabled = true;
    }

    public void challegeFaield() {
        ssp.stsp(player);
        miniGame.SetActive(false);
        player.GetComponent<controlador>().enabled = true;
    }
}