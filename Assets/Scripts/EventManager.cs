using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour 
{

	public Cat cat;
	public GameObject obj;
	public GameObject pogo;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.CompareTag("Cat"))
		{

            //Spawn();
            //obj.GetComponent<CircleCollider2D> ().isTrigger;
            //renderer.color = Color.blue;
            Destroy(pogo);
            Destroy(obj);
		}
	}

//	void Spawn()
//	{
//
//		Instantiate<GameObject>(pogo, new Vector3(3, -3), Quaternion.identity);
//	}
}
