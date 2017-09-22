using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] 
[RequireComponent(typeof(Light))] 

public class onTrigger : MonoBehaviour {

	public GameObject theobject;
	public Collider Sphere;
	public bool enterswitch;
	public bool stayswitch;
	public bool exitswitch;
	public Vector3 onenterPosition;
	public string entertext;
	public string exittext;
	public bool killswitch;



	void OnTriggerEnter(Collider Sphere)
	{
		print (entertext);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		Light lamp = GetComponent<Light>();
		lamp.intensity = 12;



	}

	void OnTriggerStay(Collider Sphere)
	{
		Light lamp = GetComponent<Light>();
		lamp.intensity = 5;

	}

	void OnTriggerExit(Collider Sphere)
	{
		Light lamp = GetComponent<Light>();
		lamp.intensity = 0;
		if (killswitch == true) {
	
			Destroy (theobject);
		}
	
	}

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update ()
	{

	
			
	}



}