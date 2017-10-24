using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFollow : MonoBehaviour
{

    public Transform Player;
    public Transform Chicken;

    // Use this for initialization
    void Start()
    {

        Player = GameObject.FindWithTag("Playa").transform;

    }


    void Update()
    {

        transform.LookAt(Player);
        transform.Translate(Vector3.forward * Time.deltaTime);

    }
}
