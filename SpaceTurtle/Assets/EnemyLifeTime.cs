using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifeTime : MonoBehaviour {

	
	void Start ()
	{
		StartCoroutine(DestroyTrash());
	}
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
        		Destroy(gameObject);	
		}
	}
	
	private IEnumerator DestroyTrash()
	{
		yield return new WaitForSeconds(7f);
		Destroy(gameObject);
	}
}
