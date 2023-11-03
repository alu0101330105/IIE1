using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionPower2 : MonoBehaviour
{
    public GameObject SpiderB;
    public GameObject SpiderC;
    public void OnPointerEnter() {
        Action();
    }

    void Action() {
        Vector3 scale = SpiderB.transform.localScale;
        scale *= 1.1f;
        SpiderB.transform.localScale = scale;

        transform.position = new Vector3(3.92614889f,1.7f,-2.69899988f);
        SpiderC.transform.position = new Vector3(3.79021668f,1.5f,1.11000001f);
    }

}
