using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Cat cat;
    public Animator scratch;
    public GameObject scr;
    Vector2 catObj;
    float speed;
    int obj;
    Animator animator;
    


    void Start()
    {
        animator = GetComponent<Animator>();
    }

	void Update ()
    {
        speed = cat.speed;
        catObj = cat.transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            animator.SetInteger("State", 2);
            obj = 0;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            animator.SetInteger("State", 1);
            obj = 1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            animator.SetInteger("State", 3);
            obj = 2;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            animator.SetInteger("State", 0);
            obj = 3;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            switch(obj){
                case 0:
                scr.transform.eulerAngles = new Vector3(0, 0, 0f);
                scr.transform.position = new Vector2(catObj.x + 1.2f,catObj.y - .84f);
                scratch.SetInteger("Check", 1);
                break;

                case 1:
                scr.transform.eulerAngles = new Vector3(0, 0, -180f);
                scr.transform.position = new Vector2(catObj.x - 1.2f,catObj.y - .84f);
                scratch.SetInteger("Check", 1);
                break;

                default:
                scratch.SetInteger("Check", 0);
                break;
            }

        }else{
            scratch.SetInteger("Check", 0);
        }
    }
}
