using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive_Cube_2 : MonoBehaviour {

	private bool condition;
	// Use this for initialization
	void Start () {
		condition = true;
	}

	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y > 1.5 && condition) {
			Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
			GetComponent<Renderer> ().material.color = newColor;
			condition = false;
		}
		if (gameObject.transform.position.y <= 1.21) {
			condition = true;
		}
	}
}
