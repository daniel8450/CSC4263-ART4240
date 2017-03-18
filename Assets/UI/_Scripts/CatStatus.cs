using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatStatus : MonoBehaviour
{
	public Text livesText;
	public Text PogoText;
	public Cat playerCat;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetCatLives();
		GetCatPogo();
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
		PogoText.text = "PogoStick: " + playerCat.pogo;
	}
}
