using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public GameObject obj;
    public Cat cat;

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

                case "trigger4":
                    SceneManager.LoadScene("area4");
                    break;
                case "trigger5":
                    SceneManager.LoadScene("area5");
                    break;
                case "trigger6":
                    SceneManager.LoadScene("area6");
                    break;
                case "trigger7":
                    SceneManager.LoadScene("area7");
                    break;
                case "trigger8":
                    SceneManager.LoadScene("area8");
                    break;
                case "trigger9":
                    SceneManager.LoadScene("area9");
                    break;
                case "trigger10":
                    SceneManager.LoadScene("area10");
                    break;
                case "trigger11":
                    SceneManager.LoadScene("credits");
                    break;
                default:
                    break;
            }
        }

    }
}