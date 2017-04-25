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

                case "trigger3":
                    SceneManager.LoadScene("area3");
                    break;

                case "trigger51":
                    SceneManager.LoadScene("area51");
                    break;
                case "trigger4":
                    SceneManager.LoadScene("area4");
                    break;

                default:
                    break;
            }
        }

    }
}