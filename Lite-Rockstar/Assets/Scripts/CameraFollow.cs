﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject target;
	private Transform _t;

	// Use this for initialization
	void Start () {
		_t = target.transform;
	}
	
	// Update is called once per frame
	void Update () {
		// fixed y camera position
		transform.position = new Vector3 (_t.position.x, 0.0f, transform.position.z);
	}
}