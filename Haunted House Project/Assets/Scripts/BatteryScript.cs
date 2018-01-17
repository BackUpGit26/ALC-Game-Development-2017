using UnityEngine;
using System.Collections;

public class BatteryScript : MonoBehaviour {

	public int power = 4;

	public GameObject batterySpawn;
	public GameObject flashlight;
	
	GameObject player;

	int checkBat;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		batterySpawn = GameObject.FindWithTag("BatterySpawn");
		flashlight = player;
		
		//checkBat = flashlight.gameObject.GetComponentInChildren<FlashLight>().currentPower;
	}
	
	// Update is called once per frame
	void Update () {
		checkBat = flashlight.gameObject.GetComponentInChildren<FlashLight>().currentPower;
		 print("CkBat = "+checkBat);
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Player" && checkBat == 0){ //flashlight.gameObject.GetComponentInChildren<FlashLight>().currentPower == 0){
			flashlight.gameObject.GetComponentInChildren<FlashLight>().currentPower = power;
			Destroy(gameObject);
			batterySpawn.gameObject.GetComponentInChildren<BatterySpawn>().BatteryPickup();
			}
		}
	}

}
