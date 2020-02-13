using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    public float bulletCooldown = 80f;
    float timer = 0f;
   
    public Transform firePoint;
    public Rigidbody2D bulletPrefab;

    public void Shoot()
    {

        Rigidbody2D Bullet = Instantiate(bulletPrefab);
        Bullet.gameObject.transform.position = firePoint.position;
        ZombieBulletScript bulletM = Bullet.GetComponent<ZombieBulletScript>();
        bulletM.direction = 1;

        Rigidbody2D Bullet2 = Instantiate(bulletPrefab);
        Bullet2.gameObject.transform.position = firePoint.position;
        ZombieBulletScript bulletM2 = Bullet.GetComponent<ZombieBulletScript>();
        bulletM2.direction = -1;
    }

    
    // Update is called once per frame
    void Update()
    {
        timer += 1;

        if (timer == bulletCooldown)
        {
            timer = 0;
            Shoot();
        }
    }
}
