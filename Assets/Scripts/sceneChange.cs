using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public GameObject obj;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            if (obj.name == "sceneTriggerOne")
            {
                SceneManager.LoadScene("LevelOne");
                
            }
            else
            {
                SceneManager.LoadScene("LevelZero");
            }
            

        }

    }
}