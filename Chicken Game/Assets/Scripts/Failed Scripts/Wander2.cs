﻿using UnityEngine;
using System.Collections;


[RequireComponent(typeof(CharacterController))]
public class Wander2 : MonoBehaviour
{
	public float speed = 2;
	public float directionChangeInterval = 1;
	public float maxHeadingChange = 30;

	CharacterController controller;
	float heading;
	Vector3 targetRotation;

	void Awake ()
	{
		controller = GetComponent<CharacterController>();

		
		heading = Random.Range(0, 360);
		transform.eulerAngles = new Vector3(0, heading, 0);

		StartCoroutine(NewHeading());
	}

	void Update ()
	{
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
		var floor = transform.eulerAngles.y - maxHeadingChange;
		var ceil  = transform.eulerAngles.y + maxHeadingChange;
		heading = Random.Range(floor, ceil);
		targetRotation = new Vector3(0, heading, 0);
	}
}
