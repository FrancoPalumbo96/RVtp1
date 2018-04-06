using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorMovement : MonoBehaviour {

	private GameObject ball;
	private GameObject[] balls;
	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("Sphere 1");
		balls = GameObject.FindGameObjectsWithTag ("ball");
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
		}

	}
}
