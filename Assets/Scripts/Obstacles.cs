using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Cat cat;
    public GameObject obj;
    

    void Update()
    {
        Physics2D.IgnoreCollision(cat.GetComponent<PolygonCollider2D>(), GetComponent<BoxCollider2D>());
    }


    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            if(obj.name == "spikes")
            {
                cat.life -= 1.0f;
            }
            if(obj.name == "pit")
            {
                cat.speed = cat.speed / 2.5f;
            }
            if(obj.name == "slideup")
            {
                transform.position += Vector3.up * 30 * Time.deltaTime;
            }
            if (obj.name == "slideleft")
            {
                transform.position += Vector3.left * 30 * Time.deltaTime;
            }
            if (obj.name == "slideright")
            {
                transform.position += Vector3.right * 30 * Time.deltaTime;
            }
            if (obj.name == "slidedown")
            {
                transform.position += Vector3.down * 30 * Time.deltaTime;
            }
        }
	}
    void OnTriggerExit2D (Collider2D other)
    {
        if(obj.name == "pit")
        {
            cat.speed = 7;
        }
    }
}
