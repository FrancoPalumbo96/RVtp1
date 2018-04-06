using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

	public Light[] lights;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.CompareTag ("Player") && Input.GetKeyDown(KeyCode.L)) {
			for (int i = 0; i < lights.Length; i++) {
				
				lights[i].enabled = !lights[i].enabled;
			}

		}

	}

}
