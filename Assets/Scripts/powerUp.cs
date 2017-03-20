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
                cat.speed = 18;
            }

            if (obj.name == "milk")
            {
                cat.life += 3;
                if(cat.life > 9)
                {
                    cat.life = 9;
                }
            }

            if (obj.name == "food")
            {
                cat.life += 3;
            }

            if (obj.name == "waterPogo")
            {
                cat.pogo = 1;
            }
  
            Destroy(obj);
        }

    }





	
}
