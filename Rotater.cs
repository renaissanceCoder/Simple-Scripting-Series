using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {

    public enum ROTATIONAXIS {
        xAxis,
        yAxis,
        zAxis
    }

    public float maxRotationAngle;
    public float period;

    float myTime;

    public ROTATIONAXIS rotationAxis;

	
	// Update is called once per frame
	void FixedUpdate () {
        if(rotationAxis == ROTATIONAXIS.xAxis) 
        {
            myTime += Time.deltaTime;
            float phase = Mathf.Sin(myTime / period);
            transform.localRotation = Quaternion.Euler(new Vector3(phase * maxRotationAngle,0,0));
        } 

        else if (rotationAxis == ROTATIONAXIS.yAxis) 
        {
			myTime += Time.deltaTime;
			float phase = Mathf.Sin(myTime / period);
			transform.localRotation = Quaternion.Euler(new Vector3(0, phase * maxRotationAngle, 0));
        }

        else if (rotationAxis == ROTATIONAXIS.zAxis) 
        {
			myTime += Time.deltaTime;
			float phase = Mathf.Sin(myTime / period);
			transform.localRotation = Quaternion.Euler(new Vector3(0, 0, phase * maxRotationAngle));
        }
	}
}
