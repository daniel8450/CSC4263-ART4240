﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float life;
    public float speed;
    public float pogo;
    

   void Start()
    {
        //pogo: 0 is default, 1 is water
        pogo = 0;
        life = 9.0f;
        speed = 7.0f;
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
