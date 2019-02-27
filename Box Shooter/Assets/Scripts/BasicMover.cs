using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour {

    public float spinSpeed=180.0f;
    public float motionMagnitude = 0.1f;
	
	// Update is called once per frame
	void Update () {
        //rotate around the up axis of the gameObject
        gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);

        //move up and down over time 
	}
}
