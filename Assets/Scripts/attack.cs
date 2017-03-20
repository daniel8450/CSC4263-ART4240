﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {

    public Vector2 force;
    public GameObject catObject;
    public GameObject clawObject;
    Rigidbody2D claw;
    Vector3 catObj;
    Vector3 clawObj;
    double obj;


    void Start()
    {
        
        claw = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
       
        catObj = catObject.transform.position;
        clawObj = clawObject.transform.position;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            clawObject.transform.position = new Vector3(catObj.x - .676f, catObj.y + .474f, catObj.z);
            obj = 0;


        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            clawObject.transform.position = new Vector3(catObj.x + .676f, catObj.y + .474f, catObj.z);
            obj = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            force.Set(0, -400);
            claw.AddForce(force);

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            force.Set(0, 400);
            claw.AddForce(force);
            if (obj==0)
            {
                clawObject.transform.position = new Vector3(catObj.x - .676f, catObj.y + .474f, catObj.z);
            }
            else if(obj==1)
            {
                clawObject.transform.position = new Vector3(catObj.x + .676f, catObj.y + .474f, catObj.z);
            }

        }
        else if (clawObj.y < catObj.y - .8f)
        {
            if (obj == 0)
            {
                clawObject.transform.position = new Vector3(catObj.x - .676f, catObj.y + .474f, catObj.z);
            }
            else if (obj == 1)
            {
                clawObject.transform.position = new Vector3(catObj.x + .676f, catObj.y + .474f, catObj.z);
            }
        }

    }
}