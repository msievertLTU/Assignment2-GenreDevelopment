using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float gunCooldown = 25;
    public float bulletClip = 8;
    public float maxClip = 8;

    public Transform firePoint;
    public Rigidbody2D bulletPrefab;

    void Shoot()
    {
        Rigidbody2D Bullet = Instantiate(bulletPrefab);
        Bullet.gameObject.transform.position = firePoint.position;
    }

    void Reload()
    {
        gunCooldown = 10;
        bulletClip = maxClip;
    }

    void Update()
    {
        gunCooldown -= 1;
        if (Input.GetKeyDown("r"))
        {
            Reload();
        }

        if (Input.GetAxis("Jump") != 0 && gunCooldown <= 0)
        {
            if (bulletClip > 0)
            {
                bulletClip -= 1;
                Shoot();
            }
            gunCooldown = 10;
        }
    }
}
