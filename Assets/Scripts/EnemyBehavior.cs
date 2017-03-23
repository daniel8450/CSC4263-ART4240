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
        else if (Vector2.Distance(transform.transform.position, target.transform.position) > 20)
        {
            transform.position = Vector2.MoveTowards(enemyPos, playerPos, 0 * Time.deltaTime);
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
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("sand") || (other.CompareTag("water")))
        {
            other.GetComponent<noWalk>().moveCol.isTrigger= false;
        }
    }
}