using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public GameObject obj;
    public Cat cat;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            if (obj.name == "catNip")
            {
                Debug.Log("speedUP");
                cat.speed = 5;
            }

            if (obj.name == "milk")
            {
                cat.life += 1;
                Debug.Log("lifeUP");
            }

            if (obj.name == "food")
            {
                Debug.Log("healthUP");
                cat.health += 2;
            }

            Destroy(obj);
        }

    }





	
}
