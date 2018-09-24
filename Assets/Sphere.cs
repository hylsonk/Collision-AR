using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerEnter(Collider other) {
		Debug.Log("Object Enter");
		Color newColor;
		newColor = other.GetComponent<Renderer>().material.color;
		gameObject.GetComponent<Renderer>().material.color = newColor;
	}

	private void OnTriggerExit(Collider other) {
		Debug.Log("Object Exit");
		Color newColor = Color.white;
		gameObject.GetComponent<Renderer>().material.color = newColor;
	}

	private void OnTriggerStay(Collider other) {
		Debug.Log("Object Stay");
	}
}
