using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour 
{

	public Cat cat;
	public GameObject obj;
	public GameObject pogo;
	//SpriteRenderer renderer;

	void Start()
	{
		//renderer = gameObject.GetComponent<SpriteRenderer>();
		//obj = GetComponent<CircleCollider2D> ();
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.CompareTag("Cat"))
		{
			//GameObject.FindGameObjectWithTag ("switch").activeSelf = false;
			//GameObject ref = Instantiate(myObj, myPosition, myRotation) as GameObject; 
			//GameObject re = Instantiate(3, -3, 0) as GameObject; 
			Spawn();
			//obj.GetComponent<CircleCollider2D> ().isTrigger;
			//renderer.color = Color.blue;
            Destroy(obj);
		}
	}

	void Spawn()
	{

		Instantiate<GameObject>(pogo, new Vector3(3, -3), Quaternion.identity);
	}
}
