using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Cat cat;
    public GameObject obj;

    void Update()
    {
        Physics2D.IgnoreCollision(cat.GetComponent<CapsuleCollider2D>(), GetComponent<BoxCollider2D>());
        Physics2D.IgnoreCollision(cat.GetComponent<CircleCollider2D>(), GetComponent<BoxCollider2D>());
    }


    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            switch (obj.tag)
            {
                case "spikes":
                    cat.loseLife(1);
                    break;
                case "pit":
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
        }else if (col.CompareTag("Enemy") && obj.tag == "spikes")
        {
            col.GetComponent<Enemy>().health -= 1;
        }
	}
    void OnTriggerExit2D (Collider2D other)
    {
        if(obj.tag == "pit")
        {
            cat.speed = 9;
        }
    }
}
