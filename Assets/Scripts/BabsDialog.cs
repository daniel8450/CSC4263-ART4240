﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabsDialog : MonoBehaviour
{
    public Cat theCat;
    Vector2 playerPos;
    public Transform cat;
    public GameObject dog;
    public GameObject dog1;
    public GameObject coon1;
    public GameObject coon;
    public GameObject man;
    public GameObject drillPrefab;
    bool isCreated;
    Vector3 drillSpot = new Vector3(-5, 8, 0);

    public string[] babsTalk = {"My precious cat toy! I've forgotten where I left it!\n(Press A)",
         "I refuse to move from this spot until my toy is returned to me.\n(Press A)",
         "You, crippled cat! Take my drill Pogo and find my toy for me.\n(Press A)"};
    int box = 0;
    Rect dialogueRect = new Rect(70, 100, 400, 50);
    bool showBox;

    void Start()
    {
        drillPrefab.SetActive(false);
    }


    void Update()
    {
        playerPos = new Vector2(cat.localPosition.x, cat.localPosition.y);

        if ((Vector2.Distance(transform.transform.position, cat.transform.position) < 3) && (theCat.hasToy == false))
        {
            showBox = true;
            //cat.gameObject.SetActive(false);
            dog.gameObject.SetActive(false);
            coon.gameObject.SetActive(false);
            dog1.gameObject.SetActive(false);
            coon1.gameObject.SetActive(false);
            man.gameObject.SetActive(false);
        }
        else
        {
            //cat.gameObject.SetActive(true);
            dog.gameObject.SetActive(true);
            coon.gameObject.SetActive(true);
            man.gameObject.SetActive(true);
            showBox = false;
        }

        if ((showBox == true) && (Input.GetKey(KeyCode.A)))
        {

            box++;
        }

        if (box == 2)
        {
            if (!isCreated)
            {
                //Instantiate(drillPrefab, drillSpot, Quaternion.identity);
                drillPrefab.SetActive(true);
                isCreated = true;
            }

        }
    }

    void OnGUI()
    {
        if ((box < babsTalk.Length) && showBox == true)
        {
            GUI.Box(dialogueRect, babsTalk[box]);
        }
        else //if ((box >= babsTalk.Length))
        {


        }
    }
}


