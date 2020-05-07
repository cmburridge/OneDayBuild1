using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifeTime : MonoBehaviour {

	
	void Start ()
	{
		StartCoroutine(DestroyTrash());
	}

	private IEnumerator DestroyTrash()
	{
		yield return new WaitForSeconds(6f);
		Destroy(gameObject);
	}
}
