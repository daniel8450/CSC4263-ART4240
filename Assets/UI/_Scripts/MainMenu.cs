﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}

	public void StartButton()
	{
		//SceneManager.SetActiveScene(1);
	}
	
	public void CheatButton()
	{

	}

	public void QuitButton()
	{
		Application.Quit();
	}
}
