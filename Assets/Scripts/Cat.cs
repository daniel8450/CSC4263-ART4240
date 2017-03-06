using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float health;
    public float life;
    public float speed;
    //public Item[] inv = new Item[5];

   void Start()
    {
        health = 10.0f;
        life = 9.0f;
        speed = 2.0f;
    }



    void Update ()
    {
		if(health == 0)
        {
            life -= 1;
        }
	}
}
