using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Cat cat;
    public GameObject obj;
    Animator animator;


    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            if(obj.name == "Spikes")
            {
                cat.life -= 1.0f;
            }
            if(obj.name == "Sandpit")
            {
                
                cat.speed = cat.speed / 2.5f;
            }
            if(obj.name == "SlideUp")
            {
                transform.position += Vector3.up * cat.speed * Time.deltaTime;
            }
        }
	}
    void OnTriggerExit2D (Collider2D other)
    {
        if(obj.name == "Sandpit")
        {
            cat.speed = cat.speed * 2.5f;
        }
    }
}
