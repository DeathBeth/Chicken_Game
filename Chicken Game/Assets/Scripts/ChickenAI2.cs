using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI2 : MonoBehaviour {

	public float speed = 8.0f;
	public float rotSpeed = 120.0f;
	public Transform wolf;
	public Transform player;
	Vector3 turnAround = new Vector3(0,1,0);
	public Quaternion rot;
	public Transform chickenPen;
	public int points;


	void Update () {
		Wander();
	}

	void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "player"){
			transform.rotation = new Quaternion(0,180,0,0);
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
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
		if(other.gameObject.tag =="player"){
			ScoreManager.AddPoints(points);
			//add points to score
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
			//send chicken to chicken pen
		}
	}
		
	}	

