using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Cat cat;
    public GameObject obj;
    public GameObject dog;
    Vector2 pos;
    public float localX;
    public float localY;
    public float amount;

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
        pos = obj.transform.position;
        for (int i = 0; i < amount; i++)
        {
            Instantiate<GameObject>(dog, new Vector2(pos.x + localX + i, pos.y + localY + i), Quaternion.identity);
        }
    }
}
