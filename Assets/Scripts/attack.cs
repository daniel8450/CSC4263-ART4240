using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {

    public Vector2 force;
    public GameObject catObject;
    public GameObject clawObject;
    Rigidbody2D claw;
    BoxCollider2D box;
    Vector2 catObj;
    Vector2 clawObj;
    Vector2 tempPos;
    double obj = 0;


    void Start()
    {
        claw = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();          
    }

    void Update()
    {
        catObj = catObject.transform.position;
        clawObj = clawObject.transform.position;

        
            clawObject.transform.eulerAngles = new Vector3(0, 0, 0f);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            clawObject.transform.position = new Vector2(catObj.x, catObj.y-1);
            obj = 0;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            clawObject.transform.position = new Vector2(catObj.x, catObj.y-1);
            obj = 1;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            clawObject.transform.eulerAngles = new Vector3(0, 0, 0f);
            clawObject.transform.position = new Vector2(catObj.x, catObj.y-1);
            obj = 2;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            clawObject.transform.eulerAngles = new Vector3(0, 0, 0f);
            clawObject.transform.position = new Vector2(catObj.x, catObj.y-1);
            obj = 3;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            box.enabled = true;

            if (obj == 0)
            {
                clawObject.transform.eulerAngles = new Vector3(0, 0, 0f);
                clawObject.transform.position = new Vector2(catObj.x-1, catObj.y-1);
            }
            else if (obj == 1)
            {
                clawObject.transform.eulerAngles = new Vector3(0, 0, 0f);
                clawObject.transform.position = new Vector2(catObj.x+1, catObj.y-1);
            }
            else if (obj == 2)
            {
                clawObject.transform.eulerAngles = new Vector3(0, 0, 0f);
                clawObject.transform.position = new Vector2(catObj.x, catObj.y+.7f);
            }
            else if (obj == 3)
            {
                clawObject.transform.eulerAngles = new Vector3(0, 0, 0f);
                clawObject.transform.position = new Vector2(catObj.x, catObj.y-1.5f);
            }
        }
        else
        {
            box.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            clawObject.transform.position = new Vector2(catObj.x, catObj.y-1);

        }
    }
}

