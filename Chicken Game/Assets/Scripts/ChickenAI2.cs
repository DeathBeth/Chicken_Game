using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI2 : MonoBehaviour {

	public float speed = 2.0f;
	public float rotSpeed = 80.0f;
	public Transform wolf;
	public Transform player;
	Vector3 turnAround = new Vector3(0,1,0);
	public Quaternion rot;
	public Transform chickenPen;
	public int points = 10;

	void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "player"){
			transform.rotation = new Quaternion(0,180,0,0);
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
	}

	// Update is called once per frame
	void Update () {
		Wander ();
	}


	// void OnTriggerEnter(Collider other){
	// 	if(other.gameObject.tag == "wall"){
	// 		transform.Rotate(turnAround * rotSpeed * Time.deltaTime);	
	// 		}
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
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
			
		}
	}
	

}
