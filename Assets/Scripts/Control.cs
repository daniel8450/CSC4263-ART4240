using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Cat cat;
    public Animator scratch;
    float speed;
    Animator animator;
    


    void Start()
    {
        animator = GetComponent<Animator>();
    }

	void Update ()
    {
        speed = cat.speed;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            animator.SetInteger("State", 2);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            animator.SetInteger("State", 1);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            animator.SetInteger("State", 3);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            animator.SetInteger("State", 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
           scratch.SetInteger("Check", 1);
        }else
        {
            scratch.SetInteger("Check", 0);
        }
    }
}
