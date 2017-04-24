﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtObj : MonoBehaviour {

    Vector2 playerPos;
    public Transform player;
    public Cat cat;
    public GameObject dirtObj;

    void Start () {

	}
	

	void Update ()
    {
        playerPos = new Vector2(player.localPosition.x, player.localPosition.y);
        if ((Vector2.Distance(transform.transform.position, player.transform.position) < 1.5) && (Input.GetKey(KeyCode.A)) && (cat.pogo == 3))
        {
            Destroy(dirtObj);
        }
    }
}
