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
	
	// Update is called once per frame
	void Update () {
		if(batSpawned == false){
			StartCoroutine(SpawnBat())
		}
	
	}
	void OnTriggerEnter(){
		if(other.GameObject.tag == "battery"){
			batSpawned = true;
		}
		else{
			batSpawned = false;
		}
	}
	IEnumerator SpawnBat(){
		yield return new WaitForSeconds(spawnTime);
		Rigidbody clone;
		(Rigidbody)Instantiate(battery, spawnPoint.position, spawnPoint.Rotation);
	}

	}
}
