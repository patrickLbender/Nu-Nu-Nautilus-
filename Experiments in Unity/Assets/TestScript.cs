using System.Collections;
using UnityEngine;
using System.Collections.Generic;

//[RequireComponent(typeof(AudioSource))] 

public class TestScript : MonoBehaviour {

	public GameObject theobject;

	public Vector3 position1;
	//public Vector3 rotation1;
	//public int rotationspeed1;

	public Vector3 position2;
	//public Vector3 rotation2;
	//public int rotationspeed2;

	public Vector3 position3;
	//public Vector3 rotation3;
	//public int rotationspeed3;

	public Vector3 position4;
	//public Vector3 rotation4;
	//public int rotationspeed4;

	public Vector3 position5;
	//public Vector3 rotation5;
	//public int rotationspeed5;

	public Vector3 position6;
	//public Vector3 rotation6;
	//public int rotationspeed6;

	public Vector3 position7;
	//public Vector3 rotation7;
	//public int rotationspeed7;

	public Vector3 position8;
	//public Vector3 rotation8;
	//public int rotationspeed8;

	public Vector3 position9;
	//public Vector3 rotation8;
	//public int rotationspeed8;


	public bool toggleonoff;

	// Use this for initialization
	void Start () {
		toggleonoff = true;
	}
	
	// Update is called once per frame
	void Update () {
		//if (flip == true) {
		if (Input.GetKeyDown (KeyCode.B)) {
				//print ("hey");
				theobject.transform.position = position1;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
		if (Input.GetKeyDown (KeyCode.N)) {
			//print ("hey");
			theobject.transform.position = position2;
			//theobject.transform.Rotate (rotation2, rotationspeed2);
		}

		if (Input.GetKeyDown (KeyCode.M)) {
			//print ("hey");
			theobject.transform.position = position3;
			//theobject.transform.Rotate (rotation3, rotationspeed3);
		}

		if (Input.GetKeyDown (KeyCode.G)) {
			//print ("hey");
			theobject.transform.position = position4;
			//theobject.transform.Rotate (rotation4, rotationspeed4);
		}

		if (Input.GetKeyDown (KeyCode.H)) {
			//print ("hey");
			theobject.transform.position = position5;
			//theobject.transform.Rotate (rotation5, rotationspeed5);
		}

		if (Input.GetKeyDown (KeyCode.J)) {
			//print ("hey");
			theobject.transform.position = position6;
			//theobject.transform.Rotate (rotation6, rotationspeed6);
		}

		if (Input.GetKeyDown (KeyCode.T)) {
			//print ("hey");
			theobject.transform.position = position7;
			//theobject.transform.Rotate (rotation7, rotationspeed7);
		}

		if (Input.GetKeyDown (KeyCode.Y)) {
			//print ("hey");
			theobject.transform.position = position8;
			//theobject.transform.Rotate (rotation8, rotationspeed8);
		}
		if (Input.GetKeyDown (KeyCode.U)) {
			//print ("hey");
			theobject.transform.position = position9;
			//theobject.transform.Rotate (rotation8, rotationspeed8);
		}
		}
	}
//}
