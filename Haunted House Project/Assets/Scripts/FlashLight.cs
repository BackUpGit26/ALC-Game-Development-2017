using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FlashLight : MonoBehaviour {

	public bool lightOn = true;
	
	Light light;

	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
		// Set Light default to ON
		lightOn = true;
		light.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		// Toggle light on/off when L key is pressed
		if (Input.GetKeyUp (KeyCode.L) && lightOn) {
			lightOn = false;
			light.enabled = false;

		}

		else if (Input.GetKeyUp (KeyCode.L) && !lightOn){
			lightOn = true;
			light.enabled = true;
		}
	}
}
