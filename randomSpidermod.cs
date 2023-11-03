using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpiderMod : MonoBehaviour
{
  public float speed = 1f;
  public GameObject Silla;
  public GameObject Mesa;
  private Vector3 initialPosition;
  private Vector3 finalPosition;
  void Start() {
    float rand1 = Random.Range(2f, -2f);
    float rand2 = Random.Range(2f, -2f);
    initialPosition = new Vector3(rand1, 0, rand1);
    finalPosition = new Vector3(rand2, 0, rand2);
  }

  // Update is called once per frame
  void Update() {
    transform.position = Vector3.Lerp(initialPosition, finalPosition, Mathf.PingPong(Time.time * speed, 1.0f));
  }
}