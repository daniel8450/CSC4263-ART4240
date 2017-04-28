using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noWalk : MonoBehaviour
{
    public Cat cat;
    public Collider2D moveCol;

    void start()
    {

        Physics2D.IgnoreCollision(cat.GetComponent<CapsuleCollider2D>(), GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(cat.GetComponent<CircleCollider2D>(), GetComponent<BoxCollider2D>());

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (cat.pogo == 1 && moveCol.tag == "sand")
        {
            moveCol.isTrigger = true;
        }
        else if (cat.pogo >= 2 && (moveCol.tag == "water" || moveCol.tag == "sand"))
        {
            moveCol.isTrigger = true;
        }
        else if(cat.pogo >= 2 && (moveCol.tag == "water" || moveCol.tag == "sand"))
        {
            moveCol.isTrigger = true;
        }
        else
        {
            moveCol.isTrigger = false;

        }
        
        
    }
}