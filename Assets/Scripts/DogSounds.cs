using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSounds : MonoBehaviour
{
    public AudioClip[] dogSounds;
    public AudioSource audioSource;
    public float time = 50f;

	// Update is called once per frame
	void Update ()
    {
        if (time <= 0)
        {
            audioSource.clip = dogSounds[Random.Range(0, 16)];
            audioSource.Play();
            time = Random.Range(125f, 475f);
        }
        else
        {
            time--;
        }
	}
}
