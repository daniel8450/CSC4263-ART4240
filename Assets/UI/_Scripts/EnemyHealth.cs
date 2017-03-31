using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    const int enemyNum = 10;
    public Slider slide;
    public Enemy[] enemies;
    public Slider[] enemySlide;

    void Start()
    {
        slide.minValue = 0;
        slide.wholeNumbers = true;

        enemies = new Enemy[enemyNum];
        enemySlide = new Slider[enemyNum];

        for (int i = 0; i < enemyNum; i++)
        {
            if (enemies[i] != null)
            {
                Slider arrSlide = slide;
                arrSlide.maxValue = enemies[i].health;
                arrSlide.value = arrSlide.maxValue;
                arrSlide.transform.position = new Vector3(enemies[i].transform.position.x, enemies[i].transform.position.y + 5);
                enemySlide[i] = arrSlide;
            }
        }
    }

    private void Update()
    {
        for(int i = 0; i < enemyNum; i++)
        {
            if(enemies[i] != null)
            {
                enemySlide[i].value = enemies[i].health;
            }
            else
            {
                if(enemySlide[i] != null)
                {
                    Destroy(enemySlide[i]);
                }
            }
        }
    }
}
