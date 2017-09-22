using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCursor : MonoBehaviour {

	public GameObject theobject;

	/*public GameObject object1;
	public GameObject object2;
	public GameObject object3;
	public GameObject object4;
	public GameObject object5;
	public GameObject object6;
	public GameObject object7;
	public GameObject object8;
	public GameObject object9;
*/

	public Vector3 rotation;
	public float rotationspeed;

	public Vector3 startingposition;

	public Vector3 position1;
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

	public Vector3 position10;
	public Vector3 position11;
	public Vector3 position12;
	public Vector3 position13;
	public Vector3 position14;
	public Vector3 position15;
	public Vector3 position16;
	public Vector3 position17;
	public Vector3 position18;
	public Vector3 position19;
	public Vector3 position20;
	public Vector3 position21;
	public Vector3 position22;
	public Vector3 position23;
	public Vector3 position24;
	public Vector3 position25;



	public bool toggleonoff;

	// Use this for initialization
	void Start () {
		//toggleonoff = true;


	}

	// Update is called once per frame
	void Update () {
		theobject.transform.Rotate (rotation, rotationspeed);

		//if (Input.GetKeyDown (KeyCode.Space))
	//	{
		if (toggleonoff == true) {

			if (Input.GetKeyDown (KeyCode.Q)) {
				//print ("hey");
				theobject.transform.position = position1;

				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.W)) {
				//print ("hey");
				theobject.transform.position = position2;
				//theobject.transform.Rotate (rotation2, rotationspeed2);
			}

			if (Input.GetKeyDown (KeyCode.E)) {
				//print ("hey");
				theobject.transform.position = position3;
				//theobject.transform.Rotate (rotation3, rotationspeed3);
			}

			if (Input.GetKeyDown (KeyCode.R)) {
				//print ("hey");
				theobject.transform.position = position4;
				//theobject.transform.Rotate (rotation4, rotationspeed4);
			}

			if (Input.GetKeyDown (KeyCode.T)) {
				//print ("hey");
				theobject.transform.position = position5;
				//theobject.transform.Rotate (rotation5, rotationspeed5);
			}

			if (Input.GetKeyDown (KeyCode.Y)) {
				//print ("hey");
				theobject.transform.position = position6;
				//theobject.transform.Rotate (rotation6, rotationspeed6);
			}

			if (Input.GetKeyDown (KeyCode.U)) {
				//print ("hey");
				theobject.transform.position = position7;
				//theobject.transform.Rotate (rotation7, rotationspeed7);
			}

			if (Input.GetKeyDown (KeyCode.I)) {
				//print ("hey");
				theobject.transform.position = position8;
				//theobject.transform.Rotate (rotation8, rotationspeed8);
			}
			if (Input.GetKeyDown (KeyCode.P)) {
				//print ("hey");
				theobject.transform.position = position9;
				//theobject.transform.Rotate (rotation8, rotationspeed8);
			}
			if (Input.GetKeyDown (KeyCode.A)) {
				//print ("hey");
				theobject.transform.position = position10;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.S)) {
				//print ("hey");
				theobject.transform.position = position11;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.D)) {
				//print ("hey");
				theobject.transform.position = position12;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.F)) {
				//print ("hey");
				theobject.transform.position = position13;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.G)) {
				//print ("hey");
				theobject.transform.position = position14;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.H)) {
				//print ("hey");
				theobject.transform.position = position15;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.J)) {
				//print ("hey");
				theobject.transform.position = position16;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.K)) {
				//print ("hey");
				theobject.transform.position = position17;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.L)) {
				//print ("hey");
				theobject.transform.position = position18;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.Z)) {
				//print ("hey");
				theobject.transform.position = position19;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.X)) {
				//print ("hey");
				theobject.transform.position = position20;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.C)) {
				//print ("hey");
				theobject.transform.position = position21;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.V)) {
				//print ("hey");
				theobject.transform.position = position22;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.B)) {
				//print ("hey");
				theobject.transform.position = position23;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.N)) {
				//print ("hey");
				theobject.transform.position = position24;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
			if (Input.GetKeyDown (KeyCode.M)) {
				//print ("hey");
				theobject.transform.position = position25;
				//theobject.transform.Rotate (rotation1, rotationspeed1);
			}
		}
	}
}

	
