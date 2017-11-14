using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class ChickenAI : MonoBehaviour {

	public Transform enemy;
	public Transform target;

	// public Collider chickenCollider;

	public float speed = 5.0f;
	public float rotSpeed = 10.0f;
	Vector3 turnAround = new Vector3(0,1,0);

	// public float directionChangeInterval = 20;
	// public float maxHeadingChange = 50;

	// CharacterController controller;
	float heading;
	// Vector3 targetRotation;

	public Transform chickenPen;
	public int points = 10;

	// public bool inView;


	// void OnTriggerStay(Collider other){

	// 	if(other.gameObject.name == "Playa"){
	// 		Debug.Log("Player has entered chickens trigger");
	// 		transform.LookAt(target);
	// 		transform.Translate(Vector3.back*speed*Time.deltaTime);
	// 	}
	// 	if(other.gameObject.name == "Cerebus"){
	// 		Debug.Log("Wolf has entered chickens trigger");
	// 		transform.LookAt(enemy);
	// 		transform.Translate(Vector3.back*speed*Time.deltaTime);
	// 		}
	// }

	void Update (){
		Wander();
	}

	void Wander(){

		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

	void OnTriggerStay2(Collider other)
	{
		if (other.gameObject.tag == "wall"){
			transform.Rotate(turnAround * rotSpeed * Time.deltaTime);
		}
	}





// 	void Awake ()
// {
// 		controller = GetComponent<CharacterController>();

// 		heading = Random.Range(0, 360);
// 		transform.eulerAngles = new Vector3(0, heading, 0);
		
// 		StartCoroutine(NewHeading());
// }	

	// void Start () {
	// 	if(inView == true){
	// 		OnTriggerStay(chickenCollider);
	// 	}
	// 	else if(inView == false){
	// 		StartCoroutine(NewHeading());
	// 	}
	
	// 	controller = GetComponent<CharacterController>();

	// 	heading = Random.Range(0, 360);
	// 	transform.eulerAngles = new Vector3(0, heading, 0);

		
		
	// 	// StartCoroutine(NewHeading());
		
	// }
	
	
	// void FixedUpdate () {

	// 	transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
	// 	var forward = transform.TransformDirection(Vector3.forward);
	// 	controller.SimpleMove(forward * speed);
	// }

	// IEnumerator NewHeading ()
	// {
	// 	while (true) {
	// 		NewHeadingRoutine();
	// 		yield return new WaitForSeconds(directionChangeInterval);
	// 	}
	// }

	// void NewHeadingRoutine ()
	// 	{
	// 		var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
	// 		var ceil = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
	// 		heading = Random.Range(floor, ceil);
	// 		targetRotation = new Vector3(0, heading, 0);
	// 	}	

	void OnCollisionEnter(Collision other){
		if(other.gameObject.name =="Playa"){
			ScoreManager.AddPoints(points);
			//add points to score
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
			//send chicken to chicken pen
		}
	}

}




	

