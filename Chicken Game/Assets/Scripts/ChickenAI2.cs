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


	void OnTriggerStay2(Collider other){
		if(other.gameObject.name == "wall"){
			transform.Rotate(turnAround * rotSpeed * Time.deltaTime);	
			}
	}
	void Wander(){
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
