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
        if (obj.name == "dog")
        {
            health = 4;
            damage = 1;
        }

        if (obj.name == "coon")
        {
            health = 6;
            damage = 3;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            cat.life -= damage;
        }

    }

}
