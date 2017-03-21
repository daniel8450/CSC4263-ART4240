using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    private bool check = true;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Cat"))
        {
            if (check)
            {
                SceneManager.LoadScene("LevelOne");
                check = false;
            }
            else
            {
                SceneManager.LoadScene("LevelZero");
            }
            
        }

    }
}