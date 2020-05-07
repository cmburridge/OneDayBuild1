using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Spawner : MonoBehaviour
{
    
    public Transform spawnLocal;
    public GameObject[] objects;

    private void Start()
    {
        StartCoroutine(SpawnRandom());
    }

    IEnumerator SpawnRandom()
    {
        yield return new WaitForSeconds(Random.Range(2, 6));
        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnLocal.position, spawnLocal.rotation);
        StartCoroutine(SpawnRandom());
    }

}
