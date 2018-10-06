using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

public bool recording = true;
private ReplaySystem replaySystem;
	// Use this for initialization
	void Start () {

		replaySystem = FindObjectOfType<ReplaySystem>();
	}
	
	// Update is called once per frame
	void Update () {

		if(CrossPlatformInputManager.GetButton("Fire1")){recording=false; replaySystem.PlayBack();}else{recording=true;replaySystem.Record();}
		//if(recording){replaySystem.Record();}

			
	}


}
