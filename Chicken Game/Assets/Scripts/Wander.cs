using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

    public float duration;    
    public float elapsedTime   = 0f; 
    public float wait          = 0f; 
    public float waitTime      = 0f; 

    float randomX;  
    float randomZ;  

    bool move = true; 

    void Start(){
        randomX =  Random.Range(-3,3);
        randomZ = Random.Range(-3,3);
    }

    void Update ()
    {



        

        if (elapsedTime < duration && move) {
            
            transform.Translate (new Vector3(randomX,0,randomZ) * Time.deltaTime);
            elapsedTime += Time.deltaTime;

        } else {
            
            move        = false;
            wait        = Random.Range (5, 10);
            waitTime    = 0f;
        }

        if (waitTime < wait && !move) {
            
            waitTime += Time.deltaTime;

} 
	else if(!move) {
            move = true;
			elapsedTime = 0f;
            randomX = Random.Range(-3,3);
            randomZ = Random.Range(-3,3);
        }
    }




}
