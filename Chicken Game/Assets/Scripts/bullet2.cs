using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2 : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public int bulletSpeed = 30;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			Fire();
		}
	}

	void Fire(){
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

			bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
			Destroy(bullet, 2.0f);
		}
}
