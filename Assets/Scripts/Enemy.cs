﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health; 
    public int damage; 
    public Cat cat;
    public GameObject obj;

    void Start()
    {
        Physics2D.IgnoreCollision(cat.GetComponent<BoxCollider2D>(), GetComponent<CircleCollider2D>());
        Physics2D.IgnoreCollision(cat.GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());
    }


    void Update()
    {
        if(health <= 0)
        {
            Destroy(this.obj);
        }

        if(cat == null)
        {
            cat = FindObjectOfType<Cat>();
        }

        if (obj == null)
        {
            obj = this.gameObject;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            cat.loseLife(damage);
        }


        if (col.CompareTag("claw"))
        {
            health -= 2;
        }
        else
        {
            health -= 0;
        }
    }
}
