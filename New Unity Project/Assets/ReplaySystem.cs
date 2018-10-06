using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem: MonoBehaviour {

//const static rather non static means that code knows wont late change so can define as want
private const int bufferFrames=100;
private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];
private Rigidbody rigidBody;
private GameManager  manager;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		manager = GameObject.FindObjectOfType<GameManager>();


	}
	
	// Update is called once per frame
	void Update () {
	if(manager.recording){Record ();}else{PlayBack();}}

	//added public to playback and 
	public void PlayBack(){

	rigidBody.isKinematic = true;
	int frame = Time.frameCount % bufferFrames;
	print("Reading frame " + frame);
	transform.position = keyFrames[frame].position;
	transform.rotation = keyFrames[frame].rotation;
	}

	public void Record ()
	{
		rigidBody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		float time = Time.time;
		print("writing frame " + frame);
		/// is this as good as since start game
		keyFrames [frame] = new MyKeyFrame (time, transform.position, transform.rotation);
	}

	//how is this different than just having a method

	/// <summary>
	/// A structure for storing  time, rotation and position
	/// </summary>
	public struct MyKeyFrame
	{

	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;


	//make method same name as class this is the construction
	//take different named variables

		public MyKeyFrame(float aFrameTime, Vector3 aPosition, Quaternion aRotation){
			frameTime=aFrameTime;
			position=aPosition;
			rotation = aRotation;


		}


		}
	}

