using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector_Movement_2 : MonoBehaviour {
	private GameObject ball;
	private GameObject[] balls;
	private GameObject manager;
	private bool condition;
	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("Sphere 1");
		balls = GameObject.FindGameObjectsWithTag ("ball");
		manager = GameObject.FindGameObjectWithTag ("manager");
		condition = true;
	}

	// Update is called once per frame
	void Update () {
		//if (condition && manager.transform.position.x < 1 && manager.transform.position.z < -2) {
		//	for (int i = 0; i < balls.Length; i++) {
		//		balls [i].GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.None;
		//	}
		//	condition = false;
		//}

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("manager")) {
			for (int i = 0; i < balls.Length; i++) {
				balls [i].GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.None;
			}
		}

	}
}
