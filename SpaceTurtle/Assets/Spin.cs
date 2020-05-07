using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {
	
	
	void Update () {
		transform.Rotate(0,0,Random.Range(30, 90) * Time.deltaTime);
	}
}
