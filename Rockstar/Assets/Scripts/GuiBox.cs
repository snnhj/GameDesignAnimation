﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 * Displays a textbox in the middle of the screen. Disappears when you click at any position
 * 
*/



public class GuiBox : MonoBehaviour {

	public bool mShowBox = false;
	private string textBoxContent = "change this via setTextBox() \nnew line? \n ";
	public GUIStyle customGuiStyle;




	// Use this for initialization
	void Start () {
		print ("guiBOX start");

		customGuiStyle.fontSize = 30;
		
	}


	// Update is called once per frame
	void Update () {
		
	}


	public void showBox(bool state) {
		mShowBox = state;
	}
		

	public void setTextInBox(string str) {
		textBoxContent = str;
	}

	public void clearTextBox() {
		textBoxContent = "";
	}




	void OnGUI(){
		if (mShowBox) { 
			
			float xPosition = Screen.width / 4 + 400;
			float yPosition = Screen.height / 4;
			float boxWidth = Screen.width / 2;
			float boxHeight = Screen.height / 2;
		

			GUI.Box (new Rect (xPosition, yPosition, boxWidth, boxHeight), 
				textBoxContent, customGuiStyle);

			// on click disable box
			if (Input.GetMouseButtonDown (0) ) {
				setTextInBox ("zweiter text");
				SingletonData.Instance.myGlobalString = "from guibox klick";
				SingletonData.Instance.globalScreenIsVisable = true;
			}
		}
	}
}