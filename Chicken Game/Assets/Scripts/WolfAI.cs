using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class WolfAI : MonoBehaviour {

	public Transform player;
	public Transform chicken;

	public float speed = 5;
	public float directionChangeInterval = 15;
	public float maxHeadingChange = 50;

	CharacterController controller;
	float heading;
	Vector3 targetRotation;	
	
	
	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Playa"){
			Debug.Log("Player is in view of the wolf");
			transform.LookAt(player);
			transform.Translate(Vector3.forward*speed*Time.deltaTime);
		}
		else if(other.gameObject.name == "McChicken"){
			Debug.Log("Chicken is in view of the wolf");
			transform.LookAt(chicken);
			transform.Translate(Vector3.forward*speed*Time.deltaTime);
		}
		}

			void Awake ()
{
		controller = GetComponent<CharacterController>();

		heading = Random.Range(0, 360);
		transform.eulerAngles = new Vector3(0, heading, 0);
		
		StartCoroutine(NewHeading());
}	

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
		var forward = transform.TransformDirection(Vector3.forward);
		controller.SimpleMove(forward * speed);
	}

	IEnumerator NewHeading ()
	{
		while (true) {
			NewHeadingRoutine();
			yield return new WaitForSeconds(directionChangeInterval);
		}
	}

	void NewHeadingRoutine ()
		{
			var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
			var ceil = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
			heading = Random.Range(floor, ceil);
			targetRotation = new Vector3(0, heading, 0);
		}
	
}


		
	

	
	

