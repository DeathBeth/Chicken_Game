using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI2 : MonoBehaviour {

	public float speed = 2.0f;
	public Transform wolf;
	public Transform player;
	Vector3 turnAround = new Vector3(0,1,0);
	public Quaternion rot;
	public Transform chickenPen;
	public int points = 10;
	public int minusPoints;

	public int currentHealth = 0;
	public int maxHealth = 1;
	

	void Turn(){
	int randomNum = Random.Range(0,360);
	transform.Rotate(0,randomNum,0);
	}

	
	void Update () {
		Wander ();
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "player"){
			Turn();
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
		if(other.gameObject.tag == "wolf"){
			Turn();
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}

		if(other.gameObject.tag == "wall"){
			Turn();
		}
		if(other.gameObject.tag == "turnCheck"){
			print("Hit turncheck!");
			Turn();
		}
		else{
			Wander();
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

		if(other.gameObject.tag == "bullet"){
			print("You shot a chicken!");
			currentHealth -= 1;
			if(currentHealth <= 0){
				print("Chicken killed!");
				Destroy(this.gameObject);
				ScoreManager.MinusPoints(minusPoints);	
	}
		}
		if(other.gameObject.tag == "wolf"){
			print("Wolf ate chicken!");
			currentHealth -=1;
			if(currentHealth <=0){
				print("Chicken eaten!");
				Destroy(this.gameObject);
				ScoreManager.MinusPoints(minusPoints);
			}
		}
	}
	}

	

	


