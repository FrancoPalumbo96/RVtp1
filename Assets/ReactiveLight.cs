using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.UnityEventHelper;


public class ReactiveLight : MonoBehaviour {
	
	private Light light;
	public Light_Controller_Switch lightSwitch;

	// Use this for initialization
	void Start () {
		light = GetComponent<Light>();
		lightSwitch.GetComponent<VRTK_InteractableObject_UnityEvents>().OnUse.AddListener (onSwitchUsed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onSwitchUsed(object obj, InteractableObjectEventArgs args) {
		light.enabled = !light.enabled;
	}

}
