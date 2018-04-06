using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update () {

		float translation = Input.GetAxis ("Vertical")*speed;
		float sideMovement = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		sideMovement *= Time.deltaTime;

		transform.Translate (sideMovement, 0, translation);
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Cursor.lockState = CursorLockMode.Confined;
		}
	}
}
