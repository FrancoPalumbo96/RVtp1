using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInScreen : MonoBehaviour {

	public Text actualText;
	public GameObject cube;
	// Use this for initialization
	void Start () {
		actualText.text = "Hall";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			if(cube.name == "Laboratorio de Inf."){
				actualText.text = "Laboratorio de Informática";
			}
			if(cube.name == "Investigación"){
				actualText.text = "Sector de Investigación";
			}
			if (cube.name == "Sirius") {
				actualText.text = "Sirius";
			}
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			actualText.text = "Hall";
		}
	}
}
