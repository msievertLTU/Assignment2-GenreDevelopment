using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHP = 3;

    public GameObject enemy;

    public void TakeDamage(float damage)
    {
        enemyHP -= damage;
    }

    void Update()
    {
        if (enemyHP <= 0)
        {
            Destroy(enemy);
        }    
    }
}
