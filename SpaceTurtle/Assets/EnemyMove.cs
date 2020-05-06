using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

	public float speed;
	public Transform enemyPos;
	

	void Update () {
		transform.Translate(enemyPos.right * speed * Time.deltaTime);
	}
}
