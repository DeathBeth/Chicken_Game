using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletDestory : MonoBehaviour {

	void OnCollisionStay(Collision other){
		if(other.gameObject.tag == "wolf"){
			Destroy(this.gameObject);
		}
	}


}
	 
	
