using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatHolder : MonoBehaviour
{

    public int life;
    public float speed;
    public int pogo;
    public float check;
    public bool hasToy;
    private static CatHolder _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);

            pogo = 0;
            life = 9;
            speed = 9.0f;
            check = 0f;
            hasToy = false;

        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {

    }

    public void gainLife(int amt)
    {
        life += amt;
        if(life > 9)
        {
            life = 9;
        }
    }

    public void loseLife(int amt)
    {
        life -= amt;
    }

    public void gainPogo(int pog)
    {
        pogo = pog;
    }

    public void gainToy()
    {
        hasToy = true;
    }
}
