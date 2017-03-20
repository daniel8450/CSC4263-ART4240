using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noWalk : MonoBehaviour
{
    public Cat cat;
    public BoxCollider2D moveCol;

    void start()
    {
        //cat = GameObject.FindGameObjectWithTag("Cat");


    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (cat.pogo == 1)
        {
            moveCol.isTrigger = true;
 
        }
        Debug.Log("Can't bounce here");
        
    }
}