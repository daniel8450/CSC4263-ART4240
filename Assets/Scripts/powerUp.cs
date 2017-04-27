using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public Cat cat;
    public GameObject obj;
    

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            if (obj.name == "catnip")
            {
                cat.speed = 13;
            }

            if (obj.name == "milk")
            {
                cat.gainLife(3);
            }

            if (obj.name == "food")
            {
                cat.gainLife(6);
            }

            if (obj.name == "sandPogo")
            {
                cat.gainPogo(1);
            }

            if (obj.name == "waterPogo")
            {
                cat.gainPogo(2);
            }

            if(obj.name == "drillPogo")
            {
                cat.gainPogo(3);
            }

            if (obj.name == "masterPogo")
            {
                cat.gainPogo(4);
            }

            if (obj.name == "catToy")
            {
                cat.gainToy();
            }

            Destroy(obj);
        }

    }





	
}
