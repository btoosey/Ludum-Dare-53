using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
	public static ScenesManager Instance;
	public enum Scene
	{
		Level01
	}

	private void Awake()
	{
		Instance = this;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			ReloadScene();
		}
	}


	public void LoadScene(Scene scene)
	{
		SceneManager.LoadScene(scene.ToString());
	}

	public int GetActiveScene()
	{
		return SceneManager.GetActiveScene().buildIndex;
	}

	public void LoadNewGame()
	{
		SceneManager.LoadScene(Scene.Level01.ToString());
	}

/*	public void LoadNextScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}*/

	public void ReloadScene()
	{
		SceneManager.LoadScene(GetActiveScene());
	}

/*	public void LoadMainMenu()
	{
		SceneManager.LoadScene(Scene.MainMenu.ToString());
	}*/
}
