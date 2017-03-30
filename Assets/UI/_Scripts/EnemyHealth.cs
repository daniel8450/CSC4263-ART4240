using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    
    Slider slide;

    void Start()
    {
        slide.maxValue = slide.GetComponentInParent<Enemy>().health;
        slide.minValue = 0;
        slide.wholeNumbers = true;
        slide.value = slide.maxValue;
        slide.transform.position = new Vector3(0, slide.GetComponentsInParent<SpriteRenderer>().GetUpperBound(0) + 5, 0);

    }

    public void takenDamage(int amt)
    {
        slide.value = slide.value - amt;
    }
}
