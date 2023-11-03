using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureSpider : MonoBehaviour
{
  public float speed = 1f;
  public GameObject Silla;
  public GameObject Mesa;
  private Vector3 initialPosition;
  private Vector3 finalPosition;
  void Start() {
    initialPosition = new Vector3(Silla.transform.position.x, 0, Silla.transform.position.z);
    finalPosition = new Vector3(Mesa.transform.position.x, 0, Mesa.transform.position.z);
  }

  // Update is called once per frame
  void Update() {
    transform.position = Vector3.Lerp(initialPosition, finalPosition, Mathf.PingPong(Time.time * speed, 1.0f));
  }
}