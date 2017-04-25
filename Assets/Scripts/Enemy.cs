using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health; 
    public float damage; 
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
}
