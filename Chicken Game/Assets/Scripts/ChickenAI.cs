using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;

	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Playa"){
			Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
			}	

}




	

