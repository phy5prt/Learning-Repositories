﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(CrossPlatformInputManager.GetAxis("Horizontal")!=0){Debug.Log("H: " + CrossPlatformInputManager.GetAxis("Horizontal"));}
		if(CrossPlatformInputManager.GetAxis("Vertical")!=-0){Debug.Log("V: " + CrossPlatformInputManager.GetAxis("Vertical"));}
		}
}
