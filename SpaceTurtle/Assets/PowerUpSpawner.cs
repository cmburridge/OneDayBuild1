using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class PowerUpSpawner : MonoBehaviour {

	
	public Transform spawnLocal;
	public GameObject[] objects;
	public Transform characterPos;
	
	private void Start()
	{
		StartCoroutine(SpawnRandom());
		characterPos = GameObject.Find("Player").transform;
	}

	private void Update()
	{
		transform.position = new Vector3(transform.position.x, characterPos.position.y, transform.position.z);
	}

	IEnumerator SpawnRandom()
	{
		yield return new WaitForSeconds(Random.Range(30, 100));
		Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnLocal.position, spawnLocal.rotation);
		StartCoroutine(SpawnRandom());
	}
}
