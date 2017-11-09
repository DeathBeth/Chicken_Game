using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI2 : MonoBehaviour {

	public float speed=2.0f;
	public float rotSpeed=20.0f;
	Vector3 turnAround = new Vector3(0,1,0);
	public Transform chicken;
	public Transform player;
	public float damage;

	void Update () {
	
		Wander();
	}

	void OnTriggerStay(Collider other){
		
		if(other.gameObject.tag == "player"){
			transform.LookAt(player);
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
	

}
