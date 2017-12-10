using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PowerUp : MonoBehaviour {

	public GameObject powerUp;
	public bool slowRun;
	private ChickenAI2 Slowwander;

	void Start(){
		slowRun = false;
}

	// IEnumerator slowRoasted(){
	// 	GetComponent<ChickenAI2>().Slowwander();
	// 	new WaitForSeconds(5);
	// 	slowRun = false;
	// }

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "player"){
		Destroy(powerUp);
		slowRun = true;
	}
	}
	// void slowRoasted(Collider other){
	// 	if(slowRun == true){
	// 		StartCoroutine(slowRoasted);
	// 	}
	// }

}


