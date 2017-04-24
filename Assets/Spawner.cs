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
        Instantiate<GameObject>(dog, new Vector2(pos.x + localX, pos.y + localY), Quaternion.identity);
    }
}
