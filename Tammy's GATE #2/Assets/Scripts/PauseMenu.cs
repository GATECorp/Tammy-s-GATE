using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPAused = false;
	public GameObject pauseMenuUI;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p"))
		{
			if (GameIsPAused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
	}

	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = (float) 1;
		GameIsPAused = false;
	}

	void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = (float) 0;
		GameIsPAused = true;
	}

	public void LoadMenu()
	{
		Time.timeScale = (float) 1;
		SceneManager.LoadScene("MenuG");
	}

	public void QuitGame()
	{
		Debug.Log("Quitting Game...");
		Application.Quit();
	}
}
