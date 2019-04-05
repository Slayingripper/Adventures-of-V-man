using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
	
	public float smoothSpeed = 0.125f;
	public Vector3  offset;
	void LateUpdate()
	{
		// every frame weget the position that we want to snap to and we use a vector
		// to get a bit closerto that position and  how much closer we get depends on our 
		// smoothness 
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition,smoothSpeed);
		transform.position =smoothedPosition ;
		
		//transform.LookAt(target);
	
	}
}
