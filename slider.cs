using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour {
    bool sliding = false;
    bool slide = false;
    float originalPosition; 
    void OnEnable() {
        Cama.Tap += Slide;
    }

    void Slide() {
        slide = true;
    }

    void Start() {
        originalPosition = transform.position.z;
    }

    void Update() {
        if(slide) {
            transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
            if(transform.position.z >= originalPosition + 0.5) {
                sliding = true;
                slide = false;
            }
        } else {
            if(sliding) {
                transform.Translate(new Vector3(0,0,-1) * Time.deltaTime, Space.World);
                if(transform.position.z <= originalPosition) sliding = false;
            }
        }
    }
}
