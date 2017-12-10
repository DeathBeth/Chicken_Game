using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSpawn : MonoBehaviour {


public Transform spawnPoint;
  public float minHeightForDeath = -1.0f;
  public GameObject wolf; 
  
  void Update()
 {
   if(wolf.transform.position.y < minHeightForDeath)
       wolf.transform.position = spawnPoint.position;
 }
	// Use this for initialization
	void Start () {
		
	}
	

}
