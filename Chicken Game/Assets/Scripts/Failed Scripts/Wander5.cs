using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander5 : MonoBehaviour {


	public enum MovementStates{
		Idle,
		Walking,
		Resting
	}

	public MovementStates MovementType;

	private float speed = 2.0f;
	float rotateSpeed = 2.0f;
	
	public GameObject Waypoint;
	GameObject WP;
	bool wayP = false;

	float min_distance = -2.0f;
	float max_distance = 2.0f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		createWayPoint ();

		if(MovementType == MovementStates.Walking){
			createWayPoint ();
		}
		if(MovementType == MovementStates.Idle){

		}

		if(wayP){
			move();
		}
	}

	void move()
	{
		transform.position = Vector3.MoveTowards(transform.position,WP.transform.position, speed * Time.deltaTime);
	}

	void createWayPoint ()
	{
		if(!wayP)
		{
		float distance_x = transform.position.x + Random.Range(min_distance,max_distance);
		float distance_z = transform.position.z + Random.Range(min_distance,max_distance);

		WP = Instantiate(Waypoint,new Vector3(distance_x,0,distance_z),Quaternion.identity) as GameObject;


		wayP = true;
		}
	}
}
