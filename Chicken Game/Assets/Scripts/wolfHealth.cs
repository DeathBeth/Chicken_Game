using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfHealth : MonoBehaviour {

	public int currentHealth;
	public int maxHealth = 3;
	public Transform spawnPoint;
	public int points;


	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			currentHealth = 0;
			print("You monster. You even make PETA sick...");
			ScoreManager.AddPoints(points);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			currentHealth = maxHealth;		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
