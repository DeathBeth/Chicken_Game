using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAI : MonoBehaviour {


	public float moveSpeed;
	public Transform player;
	public Transform chicken;
	

	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Playa"){
			Debug.Log("Player is in view of the wolf");
			transform.LookAt(player);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
		else if(other.gameObject.name == "McChicken"){
			Debug.Log("Chicken is in view of the wolf");
			transform.LookAt(chicken);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
		}
		}
		}
	

