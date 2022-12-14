using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour{

    public AudioSource aus;

    public void LoadGame() {
        aus.Play();
        SceneManager.LoadScene(1);
    }

    public void LoadMenu() {
        SceneManager.LoadScene(0);
    }

}
