using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	public int damage = 1;
	public int time = 5;

	// Use this for initialization
	// void Start () {
	// 	StartCoroutine(DestroyBullet());
	// }

	// void OnCollisionEnter(Collision other){
	// 	var hit = other.gameObject;
	// 	var health = hit.GetComponent<wolfHealth>();

	// 	Destroy(gameObject);

	// 	if(health != null){
	// 		health.TakeDamage(damage);
	// 	}
	// 		}

	IEnumerator DestroyBullet(){
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
			}

	void OnCollisionEnter(Collision other){
		if(other.gameObject){
		Destroy(gameObject);
		}
	}
	

	
	// Update is called once per frame
	void Update () {
		
	}
}

