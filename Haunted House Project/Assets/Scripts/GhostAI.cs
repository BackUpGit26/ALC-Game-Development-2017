using UnityEngine;
using System.Collections;

public class GhostAI : MonoBehaviour {

	public float moveSpeed;
	
	public Transform target;
	
	public int damage;

	// A trigger is an entity waiting for something to trigger it and it will do something when it is triggered
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
	}
}
