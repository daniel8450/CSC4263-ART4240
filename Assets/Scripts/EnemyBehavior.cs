using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour
{

    public Transform target;
    public GameObject obj;
    Vector2 playerPos, enemyPos;
    public float moveSpeed;
    Animator animator;

    

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetInteger("State", 1);
    }

    void Update()
    {
        playerPos = new Vector2(target.localPosition.x, target.localPosition.y);//player position 
        enemyPos = new Vector2(this.transform.localPosition.x, this.transform.localPosition.y);//enemy position
        transform.eulerAngles = new Vector3(0, 0, 0);//keeps the enemy upright
        if (Vector2.Distance(transform.transform.position, target.transform.position) < 10)//move towards if player gets too close
        {
            animator.SetInteger("State", 0);
            transform.position = Vector2.MoveTowards(enemyPos, playerPos, moveSpeed*Time.deltaTime);
       
        }
        else if (Vector2.Distance(transform.transform.position, target.transform.position) > 20)
        {
            transform.position = Vector2.MoveTowards(enemyPos, playerPos, 0 * Time.deltaTime);
        }

            if (target.position.x > transform.position.x)//flips enemy to the right if player is to the right  
        {
           if(obj.tag == "man" || obj.tag == "man")
            {
                transform.localScale = new Vector3(-.85f, 0.85f, 1);
            }else
            {
                transform.localScale = new Vector3(-0.3f, 0.3f, 1);
            }

        }
        if (target.position.x < transform.position.x)//flips enemy to the left if player is to the left 
        {
            if (obj.tag == "man" || obj.tag == "man")
            {
                transform.localScale = new Vector3(.85f, 0.85f, 1);
            }
            else
            {
                transform.localScale = new Vector3(0.3f, 0.3f, 1);
            }
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