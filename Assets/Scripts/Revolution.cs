﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
	public Transform target;    // the object to rotate around
	public int speed;   // the speed of rotation
	void Start()
	{
		if (target == null)
		{
			target = this.gameObject.transform;
		}
	}
	// Update is called once per frame
	void Update()
	{
		// RotateAround takes three arguments, first is the Vector to rotate around
		// second is a vector that axis to rotate around
		// third is the degrees to rotate, in this case the speed per second
		transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
	}
}

//copied from https://www.studytonight.com/3d-game-engineering-with-unity/animation-script //
