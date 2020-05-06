using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public float upSpeed;
	public float speed;
	public Transform characterPos;
	
	void Start () 
	{
		
	}
	
	void FixedUpdate () 
	{
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(characterPos.up * speed * Time.deltaTime);
		}
		
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(characterPos.up * upSpeed * Time.deltaTime);
		}
	}
}
