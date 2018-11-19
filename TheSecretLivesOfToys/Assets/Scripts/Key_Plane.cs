﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Plane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 100 * Time.deltaTime, 0)); 
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this);
        }
    }
}