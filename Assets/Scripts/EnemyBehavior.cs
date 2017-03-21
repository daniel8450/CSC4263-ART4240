using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour
{

    public Transform target;
    Vector2 playerPos, enemyPos;
    public float moveSpeed;


    void Start()
    {
      
    }

    void Update()
    {
        playerPos = new Vector2(target.localPosition.x, target.localPosition.y);//player position 
        enemyPos = new Vector2(this.transform.localPosition.x, this.transform.localPosition.y);//enemy position
        if (Vector2.Distance(transform.transform.position, target.transform.position) < 10)//move towards if player gets too close
        {
            transform.position = Vector2.MoveTowards(enemyPos, playerPos, moveSpeed*Time.deltaTime);
       
        }
    

        if (target.position.x > transform.position.x)//flips enemy to the right if player is to the right  
        {
            transform.localScale = new Vector3(-0.3f, 0.3f, 1);
        }
        if (target.position.x < transform.position.x)//flips enemy to the left if player is to the left 
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 1);
        }
    }
    }