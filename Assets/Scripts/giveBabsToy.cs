using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveBabsToy : MonoBehaviour
{

    public Cat cat;
    public Transform player;
    Vector2 playerPos;
    public GameObject babs;

    public GameObject dog;
    public GameObject dog1;
    public GameObject coon1;
    public GameObject coon;
    public GameObject man;

    public string[] babsTalk = {"My precious cat toy!\n(Press A)",
         "You found it!\n(Press A)",
         "I guess I'll leave now.\n(Press A)"};
    int box = 0;
    Rect dialogueRect = new Rect(70, 100, 400, 50);
    bool showBox;

    void Start()
    {

    }

    void Update()
    {
        playerPos = new Vector2(player.localPosition.x, player.localPosition.y);
        if ((Vector2.Distance(transform.transform.position, player.transform.position) < 3) && (cat.hasToy == true))
        {
            //box++;
            showBox = true;
        }

        else
        {
            showBox = false;
        }

        if (showBox == true)
        {
            //cat.gameObject.SetActive(false);
            dog.gameObject.SetActive(false);
            coon.gameObject.SetActive(false);
            dog1.gameObject.SetActive(false);
            coon1.gameObject.SetActive(false);
            man.gameObject.SetActive(false);
        }

        else
        {
            showBox = false;
            //cat.gameObject.SetActive(true);
            dog.gameObject.SetActive(true);
            coon.gameObject.SetActive(true);
            man.gameObject.SetActive(true);

        }

        if ((showBox == true) && (Input.GetKeyDown(KeyCode.A)))
        {
            box++;
        }

        if (box == 3)
        {
            Destroy(babs);
        }
    }

    void OnGUI()
    {
        if ((box < babsTalk.Length) && showBox == true)
        {
            GUI.Box(dialogueRect, babsTalk[box]);
        }
        else
        {


        }
    }
}