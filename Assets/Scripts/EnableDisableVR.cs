using UnityEngine;
using System.Collections;

public class EnableDisableVR : MonoBehaviour {
	public Camera vrCameraLeft;
	public Camera vrCameraRight;
	public Camera noVR;
	public Canvas vrCanvas;


	// Use this for initialization
	public void EnableVR () {
		vrCameraLeft.enabled = true;
		vrCameraRight.enabled = true;

		noVR.enabled = false;

		vrCanvas.enabled = false;
		//Application.LoadLevel (1);
	}
	
	// Update is called once per frame
	public void DisableVR () {
		vrCameraLeft.enabled = false;
		vrCameraRight.enabled = false;

		noVR.enabled = true;

		vrCanvas.enabled = false;
		//Application.LoadLevel (1);
	}
}
