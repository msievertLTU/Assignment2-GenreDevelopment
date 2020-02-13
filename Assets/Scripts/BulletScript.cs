using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed = 5;
    public float bulletDamage = 1;

    private void Start()
    {
        Destroy(this.gameObject,1.5f);    
    }

    void BulletMove()
    {
        this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + bulletSpeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.tag.ToString());
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            EnemyHealth enemyHP = collision.gameObject.GetComponent<EnemyHealth>();
            enemyHP.TakeDamage(bulletDamage);
        }
    }

    void Update()
    {
        BulletMove();
    }
}
