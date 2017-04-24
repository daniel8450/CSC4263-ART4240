using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Cat cat;
    public GameObject obj;
    //private float tempSpeed;


    void Update()
    {
        Physics2D.IgnoreCollision(cat.GetComponent<CapsuleCollider2D>(), GetComponent<BoxCollider2D>());
    }


    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            //if (obj.name == "spikes")
            //{
            //    cat.life -= 1.0f;
            //}
            //if (obj.name == "pit")
            //{
            //    cat.speed = cat.speed / 2.5f;
            //}
            //if (obj.name == "slideup")
            //{
            //    transform.position += Vector3.up * 30 * Time.deltaTime;
            //}
            //if (obj.name == "slideleft")
            //{
            //    transform.position += Vector3.left * 30 * Time.deltaTime;
            //}
            //if (obj.name == "slideright")
            //{
            //    transform.position += Vector3.right * 30 * Time.deltaTime;
            //}
            //if (obj.name == "slidedown")
            //{
            //    transform.position += Vector3.down * 30 * Time.deltaTime;
            //}

            switch (obj.tag)
            {
                case "spikes":
                    cat.life -= 1.0f;
                    break;
                case "pit":
                    //tempSpeed = cat.speed;
                    cat.speed = cat.speed / 2.5f;
                    break;
                case "slideup":
                    transform.position += Vector3.up * 30 * Time.deltaTime;
                    break;
                case "slideleft":
                    transform.position += Vector3.left * 30 * Time.deltaTime;
                    break;
                case "slideright":
                    transform.position += Vector3.right * 30 * Time.deltaTime;
                    break;
                case "slidedown":
                    transform.position += Vector3.down * 30 * Time.deltaTime;
                    break;
                default:
                    break;
            }
        }
	}
    void OnTriggerExit2D (Collider2D other)
    {
        if(obj.tag == "pit")
        {
            cat.speed = 9;
            //cat.speed = tempSpeed;
           //cat.speed = cat.speed * 2.5f;
        }
    }
}
