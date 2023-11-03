using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionPower : MonoBehaviour
{
    public int hp = 3;
    public void OnPointerEnter() {
        Damage();
    }

    public void OnPointerExit() {
        if(hp <= 0) {
            Destroy(gameObject);
        }
    }

    void Damage() {
        hp--;

    }

}
