using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour {

	//Position
	// public float posX;
	// public float posY;
	// public float posZ;
	public Vector3 pos;
	//Rotate
	// public float rotX;
	// public float rotY;
	// public float rotZ;
	// public float rotW;
	public Quaternion rot;

	//Scale
	// public float x = 1.0f;
	// public float y = 1.0f;
	// public float z = 1.0f;
	public Vector3 scale;
	void Start () {
		scale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		//Position
		// transform.position = new Vector3(posX, posY, posZ);

		// //Rotation
		// transform.rotation = new Quaternion(rotX, rotY, rotZ, rotW);

		// //Scale
		// transform.localScale = new Vector3(x,y,z);

		transform.position = pos;
		transform.rotation = rot;
		scale = Vector3.one;
	}
}
