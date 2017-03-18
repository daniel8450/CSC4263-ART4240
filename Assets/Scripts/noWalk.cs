using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noWalk : MonoBehaviour
{
    public Cat cat; 
    public Collider2D col;

    void start()
    {
        //cat = GameObject.FindGameObjectWithTag("Cat");


    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (cat.pogo == 1)
        {
            col.isTrigger = true;
            Debug.Log(col.isTrigger);
        }
        Debug.Log("Can't bounce here");
        
    }
}