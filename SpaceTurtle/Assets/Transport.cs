﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{

	public Transform destination;
	private void OnTriggerEnter2D(Collider2D other)
	{
		other.transform.position = destination.position;
	}
}
