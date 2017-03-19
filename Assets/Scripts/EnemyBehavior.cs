using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour
{

    public Transform target;
    Quaternion enemyRotation;
    Vector2 playerPos, enemyPos;
    public float moveSpeed;


    void Start()
    {
        enemyRotation = this.transform.localRotation;
    }

    void Update()
    {
        playerPos = new Vector2(target.localPosition.x, target.localPosition.y);//player position 
        enemyPos = new Vector2(this.transform.localPosition.x, this.transform.localPosition.y);//enemy position
        if (Vector3.Distance(transform.transform.position, target.transform.position) < 10)//move towards if player gets too close
        {
            transform.position = Vector2.MoveTowards(enemyPos, playerPos, moveSpeed*Time.deltaTime);
            //Vector2 velocity = new Vector2((transform.position.x - target.position.x) * moveSpeed, (transform.position.y - target.position.y) * 0);
            //GetComponent<Rigidbody2D>().velocity = -velocity;
        }
    

        if (target.position.x > transform.position.x)//rotates enemy to the right if player is to the right  
        {
            enemyRotation.x = 180;
            transform.localRotation = enemyRotation;
        }
        if (target.position.x < transform.position.x)//rotates enemy to the left if player is to the left 
        {
            enemyRotation.x = 0;
            transform.localRotation = enemyRotation;
        }
    }
    }