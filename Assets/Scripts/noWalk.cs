using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noWalk : MonoBehaviour
{
    public Cat cat;
    public BoxCollider2D moveCol;

    void start()
    {
        


    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (cat.pogo == 1 && moveCol.tag == "sand")
        {
            moveCol.isTrigger = true;
        }
        else if (cat.pogo == 2 && (moveCol.tag == "water" || moveCol.tag == "sand"))
        {
            moveCol.isTrigger = true;
        }
        else
        {
            moveCol.isTrigger = false;

        }
        Debug.Log("Can't bounce here");
        
    }
}