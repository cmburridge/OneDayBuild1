using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Analytics;

public class Player : MonoBehaviour
{
	public int maxHealth = 5;
	public int currentHealth;
	public HealthBar healthBar;
	public Animator animator;
	public AudioSource hitSound;
	public GameObject pauseMenuUi;
	
	void Start ()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	private void Update()
	{
		if (currentHealth <= 0)
		{
			Destroy(gameObject);
		}

		if (currentHealth <= 0)
		{
			PlayerGameOver();
		}
	}

	public void PlayerGameOver()
	{
		pauseMenuUi.SetActive(true);
		Time.timeScale = 0f;
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		animator.SetBool("IsHurt", true);
		hitSound.Play();
		TakeDamage(1);
	}
	
	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
		StartCoroutine(HurtDuration());
	}

	IEnumerator HurtDuration()
	{
		yield return new WaitForSeconds(1f);
		animator.SetBool("IsHurt", false);
	}
	
}
