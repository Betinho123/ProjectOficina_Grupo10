﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour {

    public float scroolSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;
	// Use this for initialization
	void Start () {
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float newPosition = Mathf.Repeat(Time.time * scroolSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.right * newPosition;	
	}
}
