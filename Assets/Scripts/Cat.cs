﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
	public int life;
	public float speed;
	public int pogo;
	public float check;
	public bool hasToy;
	public CatHolder masterSystem;
	public int invincTime;
    public AudioClip[] clips;
    public AudioSource catAudio;

	void Start()
	{
		masterSystem = FindObjectOfType<CatHolder>();
        if(masterSystem == null)
        {
            GameObject tmp = new GameObject();
            tmp.AddComponent<CatHolder>();
            masterSystem = tmp.GetComponent<CatHolder>();
        }
		pogo = masterSystem.pogo;
		life = masterSystem.life;
		speed = masterSystem.speed;
		check = masterSystem.check;
		hasToy = masterSystem.hasToy;
	}



	void Update ()
	{
		transform.eulerAngles = new Vector3(0, 0, 0);
		if(life <= 0)
		{
            masterSystem.gainLife(9);
            UnityEngine.SceneManagement.SceneManager.LoadScene("credits");
		}
		if(invincTime > 0)
		{
			invincTime--;
            //this.gameObject
		}
	}

	public void gainLife(int amt)
	{
		life += amt;
		masterSystem.gainLife(amt);
		if(life > 9)
		{
			life = 9;
		}
	}
	
	public void loseLife(int amt)
	{
		if (invincTime <= 0)
		{
			life -= amt;
			masterSystem.loseLife(amt);
			invincTime = 160;
            catAudio.clip = clips[Random.Range(0, 7)];
            catAudio.Play();
		}
	}

	public void gainPogo(int pog)
	{
		pogo = pog;
		masterSystem.gainPogo(pog);
	}

	public void gainToy()
	{
		hasToy = true;
		masterSystem.gainToy();
	}
}
