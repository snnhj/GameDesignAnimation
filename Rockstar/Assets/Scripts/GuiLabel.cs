﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 
 * Displays a textbox in the upper left of the screen. Stays there unitl it's bool variable is disabled
 * 
*/

public class GuiLabel : MonoBehaviour {

	public bool showLabelStatus = false;
	private string textLabelContent = "change this via setTextLabel() \nnew line? \n ";
 
	private GUIStyle customGuiStyle = new GUIStyle();

	// Use this for initialization
	void Start () {
		print ("## GuiLabel.cs: started");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void showLabel(bool state) {
		showLabelStatus = state;
	}


	public void setTextLabel(string str) {
		textLabelContent = str;
	}
		

	void OnGUI(){
		if (showLabelStatus) {

			customGuiStyle.fontSize = 50;

			//rect     x, y, width, height
			GUI.Label( new Rect(1,1,Screen.width,Screen.height), textLabelContent + Time.fixedTime, customGuiStyle );
		
		}
	}
}