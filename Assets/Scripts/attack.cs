using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {

    public Vector2 force;
    public GameObject catObject;
    public GameObject clawObject;
    Rigidbody2D claw;
    Vector2 catObj;
    Vector2 clawObj;
    Vector2 tempPos;
    double obj = 0;
    //public int damageEnemy;


    void Start()
    {
        
        claw = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
        catObj = catObject.transform.position;
        clawObj = clawObject.transform.position;

        if(obj == 0 || obj == 1)
            clawObject.transform.eulerAngles = new Vector3(0, 0, -90.22201f);

        if (obj == 2 || obj == 3)
            clawObject.transform.eulerAngles = new Vector3(0, 0, 0f);

        if (Input.GetKeyDown(KeyCode.LeftArrow))// || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            clawObject.transform.position = new Vector2(catObj.x - .676f, catObj.y + .474f);
            obj = 0;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))// || Input.GetKeyUp(KeyCode.RightArrow))
        {
            clawObject.transform.position = new Vector2(catObj.x + .676f, catObj.y + .474f);
            obj = 1;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            clawObject.transform.eulerAngles = new Vector3(0, 0, 0f);
            clawObject.transform.position = new Vector2(catObj.x, catObj.y + .474f);
            obj = 2;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            clawObject.transform.eulerAngles = new Vector3(0, 0, 0f);
            clawObject.transform.position = new Vector2(catObj.x, catObj.y - 1.474f);
            obj = 3;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (obj == 0 || obj == 1 || obj == 3)
            {

                force.Set(0, -500);
                claw.AddForce(force);
            } else
            {
                force.Set(0, 500);
                claw.AddForce(force);
            }

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (obj == 0 || obj == 1 || obj == 3)
            {
                force.Set(0, 500);
                claw.AddForce(force);
            }else
            {
                force.Set(0, -500);
                claw.AddForce(force);
            }
            if (obj==0)
            {
                clawObject.transform.position = new Vector2(catObj.x - .676f, catObj.y + .474f);
            }
            else if(obj==1)
            {
                clawObject.transform.position = new Vector2(catObj.x + .676f, catObj.y + .474f);
            }
            else if (obj == 2)
            {
                clawObject.transform.position = new Vector2(catObj.x, catObj.y + .474f);
            }
            else if (obj == 3)
            {
                clawObject.transform.position = new Vector2(catObj.x, catObj.y - 1.474f);
            }

        }
        else if (clawObj.y < catObj.y - .8f)
        {
            if (obj == 0)
            {
                clawObject.transform.position = new Vector2(catObj.x - .676f, catObj.y + .474f);
            }
            else if (obj == 1)
            {
                clawObject.transform.position = new Vector2(catObj.x + .676f, catObj.y + .474f);
            }
        }
        else if (clawObj.y > catObj.y + 1f)
        {
            clawObject.transform.position = new Vector2(catObj.x, catObj.y + .474f);
        }
        else if (clawObj.y < catObj.y - 2f)
        {
            clawObject.transform.position = new Vector2(catObj.x, catObj.y - 1.474f);
        }


    }


    //NEEDS FIX
    /**
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && Input.GetKey(KeyCode.Space)) //checks to see if spacebar has been pressed and the enemy is within the collider
        {
            other.GetComponent<Enemy>().TakeDamageBadGuy(2); //calls function from Enemy script to apply damage
        }
    }
    */
}

