using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInteraction : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
			GetComponent<Renderer> ().material.color = newColor;
		}
	}
}
