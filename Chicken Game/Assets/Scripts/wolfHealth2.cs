﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfHealth2 : MonoBehaviour {

	public int currentHealth = 0;

	public int maxHealth = 5;
	public Transform spawnPoint;


	public void OnCollisionEnter(Collision boom){
		if(boom.gameObject.tag == "bullet"){
			print("Wolf is shot!");
			currentHealth -= 1;
			if(currentHealth <= 0){
				print("Wolf is killed");
				// Destroy(gameObject);
				print("Wolf is respawning...");
				transform.position = spawnPoint.position;
				// transform.rotation = spawnPoint.rotation;
				currentHealth = maxHealth;
			}
		}
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Wander>();
	}
}
