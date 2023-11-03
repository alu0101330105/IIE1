using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderSmash : MonoBehaviour
{
    public int ScoreValue = 10;
    private int Score = 0;
    void OnCollisionEnter(Collision other) {
        Debug.Log("Collision");
        if(other.gameObject.tag == "Spider") 
            ScoreUp();
    }

    void ScoreUp() {
        Debug.Log("Score: " + Score + " +" + ScoreValue);
        Score += ScoreValue;
    }

}
