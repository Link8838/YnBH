using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour{

    public LayerMask objetos;
    public bool tab, water, egg;

    public void setTab() {
        tab = true;
    }

    public bool getTab() {
        return tab;
    }
}
