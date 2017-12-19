using UnityEngine;
using System.Collections;

public class Battery_Spawn : MonoBehaviour {


	
	public GameObject battery;

	public Transform spawnPoint;

	public float spawnTime;

	public bool batSpawned;


	// Use this for initialization
	void Start () {
		batSpawned = false;
	}
	
	// // Update is called once per frame
	// void Update () {
	// 	if(batSpawned == false){
	// 		// StartCoroutine(SpawnBat(spawnTime, battery));
	// 		print("Spawn Box Empty");
	// 	}
	// 	else if(batSpawned == true){
	// 		print("Battery has spawned.");
	// 	}
	
	// }
	void OnTriggerStay(Collider other){
		print("Collision Detected");
		if(other.gameObject.tag == "battery"){
			print("Battery is in the trigger.");
			batSpawned = true;
		}
		else{
			batSpawned = false;
			print("Spawn Box is Empty");
		}
	}
	// IEnumerator SpawnBat(){
	// 	yield return new WaitForSeconds(spawnTime);
	// 	Rigidbody clone;
	// 	(Rigidbody)Instantiate(battery, spawnPoint.position, spawnPoint.Rotation);
	// }

}
