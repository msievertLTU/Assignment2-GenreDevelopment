using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBulletScript : MonoBehaviour
{
    public float bulletSpeed = 3;
    public float direction = 1;

    void Start()
    {
        Destroy(this.gameObject, 3);
    }

    public void Move()
    {
        this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x  + bulletSpeed * direction * Time.deltaTime, this.gameObject.transform.position.y - bulletSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<PlayerHealth>().playerHP -= 1;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        Move();
    }
}
