﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectorMovement : MonoBehaviour {

	public TextMesh text;
	private GameObject ball;
	private GameObject[] balls;
	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("Sphere 1");
		balls = GameObject.FindGameObjectsWithTag ("ball");
		text.text = "Hall";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			for (int i = 0; i < balls.Length; i++) {
				balls [i].GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.None;
			}
			text.text = "Laboratorio";
		}
		
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			text.text = "Hall";
		}

	}
}
