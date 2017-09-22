using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //add this with all the other “using”s on top

public class ReloadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
		{
			if(Input.GetKeyDown (KeyCode.Space))
				//Application.LoadLevel(0); //or whatever number your scene is (old way)
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

}
