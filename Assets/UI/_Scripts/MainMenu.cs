using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject cheatScreen;
	// Use this for initialization
	void Start ()
	{
        cheatScreen.SetActive(false);
	}
	
	public void CheatButton()
	{
		cheatScreen.SetActive(true);
	}

	public void QuitButton()
	{
		Application.Quit();
	}

	public void BackButton()
	{
		cheatScreen.SetActive(false);
	}

	public void GoArea(string area)
	{
        System.Console.WriteLine(area);
		SceneManager.LoadScene(area);
	}
}
