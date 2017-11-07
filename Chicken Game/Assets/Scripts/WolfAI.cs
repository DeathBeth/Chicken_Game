using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [RequireComponent(typeof(CharacterController))]

public class WolfAI : MonoBehaviour {

	public Transform player;
	public Transform chicken;
	public int damage;




	// public Transform Wall;

	public float speed = 5.0f;
	public float rotSpeed = 10.0f;
	Vector3 turnAround = new Vector3(0,1,0);

	

	// CharacterController controller;
	// float heading;
	// Vector3 targetRotation;


	// void OnTriggerStay(Collider other){


	// 	if(other.gameObject.name == "Playa"){
	// 		Debug.Log("Player is in view of the wolf");
	// 		transform.LookAt(player);
	// 		transform.Translate(Vector3.forward*speed*Time.deltaTime);
	// 	}
	// 	else if(other.gameObject.name == "McChicken"){
	// 		Debug.Log("Chicken is in view of the wolf");
	// 		transform.LookAt(chicken);
	// 		transform.Translate(Vector3.forward*speed*Time.deltaTime);
	// 	}
	// 	}

	void Update (){
			Wander ();
		
		
		// if(other.gameObject.name == "Playa"){
		// 	Debug.Log("Player is in view of the wolf");
		// 	transform.LookAt(player);
		// 	transform.Translate(Vector3.forward*speed*Time.deltaTime);
		// }
		// else if(other.gameObject.name == "McChicken"){
		// 	Debug.Log("Chicken is in view of the wolf");
		// 	transform.LookAt(chicken);
		// 	transform.Translate(Vector3.forward*speed*Time.deltaTime);
		// }
		}
	void OnCollisionEnter(Collision other)
	{
		// if(other.gameObject.name == "Playa"){
		// 	PlayerHealth.TakeDamage(damage);
		// 
	}

	void Wander (){
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

	void OnTriggerStay2(Collider other){
		if (other.gameObject.tag == "wall"){
			transform.Rotate(turnAround * rotSpeed * Time.deltaTime);
		}
	}
	// void OnCollisionEnter(Collision other)
	// {
	// 	if(other.gameObject.name == "Playa"){
	// 		PlayerHealth.TakeDamage(damage);
	// 	}

	// 	print("Wolf is attacking!");
	// 	var hit = other.gameObject;
	// 	var health = hit.GetComponent<PlayerHealth>();

	// 		if(health != null){
	// 			health.TakeDamage(damage);
	// 		}
	// }


}



		
	

	
	

