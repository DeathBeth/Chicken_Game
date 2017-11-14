using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI2 : MonoBehaviour {

	public float speed=2.0f;
	public float rotSpeed=20.0f;
	Vector3 turnAround = new Vector3(0,1,0);
	public Transform chicken;
	public Transform player;
	public int damage;

	public GameObject pcHealth;

	void Update () {
	
		Wander();
	}

	void OnTriggerStay(Collider other){
		
		if(other.gameObject.tag == "player"){
			transform.LookAt(player);
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
			print("Wolf is following!");
		}
		
	}
	

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "wall"){
			transform.Rotate(0,180,0);
	
		}
	}

	void Wander(){
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

	void OnCollisionEnter(Collision other){

		if(other.gameObject.name == "Playa"){
			var hit = other.gameObject;
			var health = hit.GetComponent<PlayerHealth>();
			print("Wolf is attacking!");

			if(pcHealth != null){
				// pcHealth.TakeDamage(damage);
				pcHealth.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
					
			}
		}
		
	}
		
}
	


