using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[RequireComponent(typeof(AudioSource))] 
[RequireComponent(typeof(Light))] 
[RequireComponent(typeof(ParticleSystem))] 

//AudioSource audio = GetComponent<AudioSource>();

public class StarControl : MonoBehaviour
{
	public string keypress;
	public AudioSource audiotoplay;
	public Light lighttoplay;
	public GameObject objecttomove;
	public Vector3 rotation;
	public float rotationspeed;
	public ParticleSystem particlesystem;

	private string keypressequal;


	// Use this for initialization
	void Start ()
	{
		keypressequal = keypress;
		//particlesystem =
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		lighttoplay.intensity = 0;
		if (Input.GetKeyDown (keypressequal)) {
			print ("hey");
		    audiotoplay.Play();
			lighttoplay.intensity = 200;
			objecttomove.transform.Rotate (rotation, rotationspeed);
			particlesystem.Emit (8);


		//	theobject.transform.position = position2;
			//theobject.transform.Rotate (rotation2, rotationspeed2);
		}


	}
}

