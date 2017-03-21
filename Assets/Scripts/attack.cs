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
    double obj = 0;


    void Start()
    {
        
        claw = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
       
        catObj = catObject.transform.position;
        clawObj = clawObject.transform.position;
        clawObject.transform.eulerAngles = new Vector3(0, 0, -90.22201f);

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            clawObject.transform.position = new Vector2(catObj.x - .676f, catObj.y + .474f);
            obj = 0;


        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            clawObject.transform.position = new Vector2(catObj.x + .676f, catObj.y + .474f);
            obj = 1;
        }




        if (Input.GetKeyDown(KeyCode.Space))
        {

            force.Set(0, -500);
            claw.AddForce(force);

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            force.Set(0, 500);
            claw.AddForce(force);
            if (obj==0)
            {
                clawObject.transform.position = new Vector2(catObj.x - .676f, catObj.y + .474f);
            }
            else if(obj==1)
            {
                clawObject.transform.position = new Vector2(catObj.x + .676f, catObj.y + .474f);
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

    }
}
