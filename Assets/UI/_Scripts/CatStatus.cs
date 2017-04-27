﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatStatus : MonoBehaviour
{
	public Text livesText;
	public Image pogoImg;
	public Sprite[] imgs = new Sprite[5];
	public Cat playerCat;
	private static CatStatus _instance;
	// Use this for initialization

	void Start ()
	{
		playerCat = FindObjectOfType<Cat>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetCatLives();
		GetCatPogo();
		if(Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.Q))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene("UITestScene");
		}

		if(playerCat == null)
		{
			playerCat = FindObjectOfType<Cat>();
		}
	}

	void GetCatSpeed ()
	{

	}

	void GetCatLives ()
	{
		livesText.text = "" + playerCat.life;
	}

	void GetCatPogo ()
	{
		pogoImg.sprite = imgs[(int)playerCat.pogo];
	}
}
