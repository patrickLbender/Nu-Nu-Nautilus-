using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCursorCustom : MonoBehaviour {

	public GameObject theobject;

	public GameObject object1;
	public GameObject object2;
	public GameObject object3;
	public GameObject object4;
	public GameObject object5;
	public GameObject object6;
	public GameObject object7;
	public GameObject object8;
	public GameObject object9;

	public Vector3 rotation;
	public int rotationspeed;



	public bool toggleonoff;


/*  public Vector3 position1;
    public Vector3 position2;
	public Vector3 position3;
	public Vector3 position4;
	public Vector3 position5;
	public Vector3 position6;
	public Vector3 position7;
	public Vector3 position8;
	public Vector3 position9;
*/



	// Use this for initialization
	void Start () {
		toggleonoff = true;


	}

	// Update is called once per frame
	void Update () {
		//if (flip == true) {
		theobject.transform.Rotate (rotation, rotationspeed);
		if (Input.GetKeyDown (KeyCode.B)) {
			//print ("hey");
			theobject.transform.position = object1.transform.position;
			//theobject.transform.Rotate (rotation1, rotationspeed1);
		}
		if (Input.GetKeyDown (KeyCode.N)) {
			//print ("hey");
			theobject.transform.position = object2.transform.position;
			//theobject.transform.Rotate (rotation2, rotationspeed2);
		}

		if (Input.GetKeyDown (KeyCode.M)) {
			//print ("hey");
			theobject.transform.position = object3.transform.position;
			//theobject.transform.Rotate (rotation3, rotationspeed3);
		}

		if (Input.GetKeyDown (KeyCode.G)) {
			//print ("hey");
			theobject.transform.position = object4.transform.position;
			//theobject.transform.Rotate (rotation4, rotationspeed4);
		}

		if (Input.GetKeyDown (KeyCode.H)) {
			//print ("hey");
			theobject.transform.position = object5.transform.position;
			//theobject.transform.Rotate (rotation5, rotationspeed5);
		}

		if (Input.GetKeyDown (KeyCode.J)) {
			//print ("hey");
			theobject.transform.position = object6.transform.position;
			//theobject.transform.Rotate (rotation6, rotationspeed6);
		}

		if (Input.GetKeyDown (KeyCode.T)) {
			//print ("hey");
			theobject.transform.position = object7.transform.position;
			//theobject.transform.Rotate (rotation7, rotationspeed7);
		}

		if (Input.GetKeyDown (KeyCode.Y)) {
			//print ("hey");
			theobject.transform.position = object8.transform.position;
			//theobject.transform.Rotate (rotation8, rotationspeed8);
		}
		if (Input.GetKeyDown (KeyCode.U)) {
			//print ("hey");
			theobject.transform.position = object9.transform.position;
			//theobject.transform.Rotate (rotation8, rotationspeed8);
		}
	}
}
//}
