using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health; 
    public float damage; 
    public Cat cat;
    public GameObject obj;

    void Update()
    {
        if(health <= 0)
        {
            Destroy(this.obj);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            cat.life -= damage;
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

    //NEEDS FIX
    /** 
    public void TakeDamageBadGuy(int damageEnemy)
    {
        health -= damageEnemy;
    }
    */
}
