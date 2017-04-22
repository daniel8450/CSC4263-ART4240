using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Cat cat;
    public GameObject obj;
    public GameObject dog;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            Spawn();
            Destroy(obj);
        }
    }

    void Spawn()
    {
        Instantiate<GameObject>(dog, new Vector2(9f, -13f), Quaternion.identity);
    }
}
