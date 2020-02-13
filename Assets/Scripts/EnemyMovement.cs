using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float zombieRange = 5;
    public float zombieSpeed = 2;

    public GameObject zombie;
    public Transform player;
    public SpriteRenderer zombieSprite;

    void Start()
    {
        zombieSprite = zombie.GetComponent<SpriteRenderer>();
        zombieSprite.flipX = false;
    }

    void KillPassedZombies()
    {
        if (zombie.transform.position.y + 2 < player.position.y)
        {
            Destroy(zombie);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collided With Player");
            Destroy(zombie);
        }
    }

    public void zombieMove()
    {
        float distanceToPlayer = zombie.transform.position.y - player.position.y;
        //Debug.Log("Distance: " + distanceToPlayer.ToString());

        if (distanceToPlayer <= zombieRange && distanceToPlayer >= 0.25)
        {
            Movement(zombieSpeed, zombieSpeed * 2);
        }
        else if (distanceToPlayer >= 0.25)
        {
            zombie.transform.position = new Vector2(zombie.transform.position.x, zombie.transform.position.y - zombieSpeed * Time.deltaTime);
        }
        else
        {
            zombie.transform.position = new Vector2(zombie.transform.position.x, zombie.transform.position.y - zombieSpeed * Time.deltaTime);
            zombieSprite.flipX = true;
        }
    }

    void Movement(float speedX, float speedY)
    {
        //Y
        if (player.position.y > zombie.transform.position.y)
        {
            zombie.transform.position = new Vector2(zombie.transform.position.x, zombie.transform.position.y + speedY * Time.deltaTime);
        }
        if (player.position.y < zombie.transform.position.y)
        {
            zombie.transform.position = new Vector2(zombie.transform.position.x, zombie.transform.position.y - speedY * Time.deltaTime);
        }

        //X
        if (player.position.x > zombie.transform.position.x)
        {
            zombie.transform.position = new Vector2(zombie.transform.position.x + speedX * Time.deltaTime, zombie.transform.position.y);
        }
        if (player.position.x < zombie.transform.position.x)
        {
            zombie.transform.position = new Vector2(zombie.transform.position.x - speedX * Time.deltaTime, zombie.transform.position.y);
        }
    }

    void Update()
    {
        zombieMove();
        KillPassedZombies();
    }
}
