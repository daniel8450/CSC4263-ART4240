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
            switch (obj.name)
            {
                case "trigger1":
                    SceneManager.LoadScene("area1");
                    break;

                case "trigger2":
                    SceneManager.LoadScene("area2");
                    break;

                default:
                    break;
            }
        }

    }
}