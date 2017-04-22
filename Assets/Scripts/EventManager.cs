using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour 
{

	public Cat cat;
	public GameObject obj;
	public GameObject dest;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.CompareTag("Cat"))
		{
            Destroy(dest);
            Destroy(obj);
		}
	}
}
