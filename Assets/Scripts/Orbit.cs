﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject Parent;
    public int Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    transform.RotateAround(Parent.transform.position, Vector3.up, Speed * Time.deltaTime);
    }
}
