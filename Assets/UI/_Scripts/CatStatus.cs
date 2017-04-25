using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatStatus : MonoBehaviour
{
	public Text livesText;
	public Image pogoImg;
	public Sprite[] imgs = new Sprite[4];
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
		if(Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.Q))
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene("UITestScene");
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
