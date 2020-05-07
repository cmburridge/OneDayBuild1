using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManager : MonoBehaviour {

	public void PlayGame()
	{
		Time.timeScale = 1f;
		UnityEngine.SceneManagement.SceneManager.LoadScene(1);
	}

	public void QuitGame()
	{
		Application.Quit();
		Debug.Log("Quit");
	}

}
