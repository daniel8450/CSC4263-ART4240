﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float life;
    public float speed;
    public float pogo;
    public float check;
    public bool hasToy;
    

   void Start()
    {
        
        pogo = 0f;
        life = 9.0f;
        speed = 9.0f;
        check = 0f;
        hasToy = false;
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
}
