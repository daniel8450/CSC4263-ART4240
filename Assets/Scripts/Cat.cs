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

    void Start()
    {
        masterSystem = FindObjectOfType<CatHolder>();
        pogo = masterSystem.pogo;
        life = masterSystem.life;
        speed = masterSystem.speed;
        check = masterSystem.check;
        hasToy = masterSystem.hasToy;
    }



    void Update ()
    {
        transform.eulerAngles = new Vector3(0, 0, 0);
		if(life == 0)
        {
            //Debug.Log("Game Over");
            //die
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
        life -= amt;
        masterSystem.loseLife(amt);
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
