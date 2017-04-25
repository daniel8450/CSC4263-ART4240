using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterEvent : MonoBehaviour
{

    public Cat cat;
    public GameObject pogo;
    public GameObject bridge;
    public GameObject obj;
    public Transform target;
    GameObject rock1;
    GameObject rock2;
    Vector2 pos;

    void Start()
    {
        pos = pogo.transform.position;
        rock1 = GameObject.Find("rockObj1");
        rock2 = GameObject.Find("rockObj2");
    }

    void Update()
    {
        if (Vector2.Distance(obj.transform.position, target.transform.position) < .8)
        {
            Destroy(obj);
            cat.check += 1;
        }

            if (cat.check == 4)
        {
            Spawn();
            cat.check += 1;
        }
    }

    void Spawn()
    {
        Instantiate<GameObject>(bridge, new Vector2(pos.x, pos.y + 1), Quaternion.identity);
        Destroy(rock1);
        Destroy(rock2);
    }
}
