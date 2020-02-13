using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunScript : MonoBehaviour
{
    public float gunCooldown = 25;
    public float bulletClip = 8;
    public float maxClip = 8;

    public Text bulletcliptext;
    public Transform firePoint;
    public Rigidbody2D bulletPrefab;

    void Start()
    {
        bulletcliptext.text = "AMMO: " + bulletClip + " | 8";
    }

    void Shoot()
    {
        Rigidbody2D Bullet = Instantiate(bulletPrefab);
        Bullet.gameObject.transform.position = firePoint.position;
        bulletcliptext.text = "AMMO: " + bulletClip + " | 8";
    }

    void Reload()
    {
        gunCooldown = 10;
        bulletClip = maxClip;
        bulletcliptext.text = "AMMO: " + bulletClip + " | 8";
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
