using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenWolfAI : MonoBehaviour {

	public float speed=5.0f;
	public float rotSpeed=120.0f;
	Vector3 turnAround = new Vector3(0,1,0);
	public Transform chicken;
	// public Transform player;
	public int damage;

	public float chaseSpeed = 7.0f;

	// public GameObject pcHealth;
	

	void Update () {
	
		Wander();
	
	}

	void OnTriggerStay(Collider other){
		
		if(other.gameObject.tag == "chicken"){
			transform.LookAt(chicken);
			transform.Translate(Vector3.forward * chaseSpeed * Time.deltaTime);
			print("Wolf is following chicken!");
				if(other.gameObject.tag == "wall"){
					Turn();
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
		else{
			Wander();
		}
		}
	}

