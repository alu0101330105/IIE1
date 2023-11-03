using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cama : MonoBehaviour {

    public delegate void Bed();
    public static event Bed Tap;

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "Bed with person with blood") {
            Debug.Log("Cama");
            Tap();
        }
    }
}
