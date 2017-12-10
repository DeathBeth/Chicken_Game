using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI2 : MonoBehaviour {

	public float speed=5.0f;
	Vector3 turnAround = new Vector3(0,1,0);
	public Transform chicken;
	public Transform player;
	public int damage;
	public GameObject pcHealth;
	public float chaseSpeed = 6.0f;
	
	void Start(){
		Turn();
	}
	void Update () {
	
		Wander();
	
	}

	void OnTriggerStay(Collider other){
		
		if(other.gameObject.tag == "player"){
			transform.LookAt(player);
			transform.Translate(Vector3.forward * chaseSpeed * Time.deltaTime);
			print("Wolf is following!");
				if(other.gameObject.tag == "wall"){
					Turn();
				if(other.gameObject.tag == "wcheckpoint"){
					Turn();
				}
				}
		}
		
	}
	void Turn(){
	int randomNum = Random.Range(0,360);
	transform.Rotate(0,randomNum,0);
	}

	void Wander(){
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
	

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "wall"){
			Turn();
		}
		if(other.gameObject.tag == "wolfCheck"){
			print("Hit wolfcheck!");
			Turn();
		}
		if(other.gameObject.tag == "wcheckpoint"){
			Turn();
		}
		else{
			Wander();
		}
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

		

	
		
		
	

	
		

	


