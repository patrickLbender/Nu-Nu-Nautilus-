using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	public Transform camTransform;

	// How long the object should shake for.
	public float shakeDuration = 0f;

	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;

	public string keypress;
	private string keypressequal;

	Vector3 originalPos;

	void Awake()
	{
		//keypressequal = keypress;
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}

	void OnEnable()
	{
		originalPos = camTransform.localPosition;
	}

	void Update()
	{
		//While((Input.GetKeyDown(KeyCode.Space)))
		//{
			//print ("H is hit");

		//	if ((shakeDuration > 0))
		//	{
				print ("this workeD!");
				camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

				shakeDuration -= Time.deltaTime * decreaseFactor;
			//}
		//	else
			//{
			//	shakeDuration = 0f;
			//	camTransform.localPosition = originalPos;
			//}
		//}
	}
}