using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene(1);
	}

	public void MainMenu ()
	{
		SceneManager.LoadScene(0);
	}

	public void CreditsScreen ()
	{
		SceneManager.LoadScene(2);
	}

	public void GameSettings ()
	{
		SceneManager.LoadScene(3);
	}
}
