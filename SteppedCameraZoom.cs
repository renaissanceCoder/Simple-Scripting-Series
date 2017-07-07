using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteppedCameraZoom : MonoBehaviour {

	public float[] FOVS = {45,30,15};
	Camera myCamera;
	int FOVpos = 0;

	// Use this for initialization
	void Start () {
		myCamera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			ZoomIn();
		}

		if (Input.GetMouseButtonDown(1)) {
			ZoomOut();
		}
	}

	void ZoomIn() {
		if (FOVpos >= FOVS.Length - 1) {
			FOVpos = FOVS.Length - 1;
		} else {
			FOVpos += 1;
		}
		myCamera.fieldOfView = FOVS[FOVpos];
	}

	void ZoomOut() {
		if (FOVpos <= 0) {
			FOVpos = 0;
		} else {
			FOVpos -= 1;
		}
		myCamera.fieldOfView = FOVS[FOVpos];
	}
}





















