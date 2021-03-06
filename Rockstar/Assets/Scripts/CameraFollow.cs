﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject mPlayerPosition; 
	private Transform mTransform;

	// Use this for initialization
	void Start () {

		print ("CameraFollow() started");
		mTransform = mPlayerPosition.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
		// fixed y camera position
		if( !SingletonData.Instance.globalClickWalkingIsDisabled ) {
			transform.position = new Vector3 (mTransform.position.x, 0.0f, transform.position.z);	
		}
	}
}