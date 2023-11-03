using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour {
    bool jumping = false;
    bool jump = false;
    void OnEnable() {
        Cama.Tap += Jump;
    }

    void Jump() {
        jump = true;
    }

    void Update() {
        if(jump) {
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
            if(transform.position.y >= 1) {
                jumping = true;
                jump = false;
            }
        } else {
            if(jumping) {
                transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                if(transform.position.y <= 0.1) jumping = false;
            }
        }
    }
}
