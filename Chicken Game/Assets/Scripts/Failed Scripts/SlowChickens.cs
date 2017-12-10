using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowChickens : MonoBehaviour {

	public float slowSpeed = 1;


	void slowWander(){
		transform.Translate(Vector3.forward * slowSpeed * Time.deltaTime);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
