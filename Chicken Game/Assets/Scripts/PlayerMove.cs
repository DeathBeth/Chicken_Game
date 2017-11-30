using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;
	public float jumpHeight;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	// public int coolDown = 3;
	// public bool canShoot = true;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var j = Input.GetAxis("Jump")* Time.deltaTime * jumpHeight;
		var y = Input.GetAxis("Horizontal")* Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;


		transform.Rotate(0,y,0);
		transform.Translate(0,0,z);
		transform.Translate(0,j,0);
	}

		public void Fire(){
	 	if(Input.GetKeyDown(KeyCode.Mouse0)){
				Shot();
			}
		}

    	void Shot() {

            var bullet = (GameObject)Instantiate(
               bulletPrefab,
               bulletSpawn.position,
               bulletSpawn.rotation);

            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
            
			Destroy(bullet, 0.5f);
        }
    }



