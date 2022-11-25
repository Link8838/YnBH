using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour{

    public LayerMask objetos;
    public bool tab, water, egg, gas;

    public void setTab() {
        tab = true;
    }

    public bool getTab() {
        return tab;
    }
    public void setGas() {
        gas = true;
    }
    public bool getGas() {
        return gas;
    }

    public void setWater() {
        tab = true;
    }

    public bool getWater() {
        return tab;
    }
}
