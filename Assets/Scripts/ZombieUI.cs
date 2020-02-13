using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieUI : MonoBehaviour
{
    public Scrollbar healthBar;
    public GameObject zombie;
    public EnemyHealth zombieHP;

    // Start is called before the first frame update
    void Start()
    {
        zombieHP = zombie.gameObject.GetComponent<EnemyHealth>();
        healthBar.size = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (zombieHP.enemyHP == 3)
        {
            healthBar.size = 1;
        }
        else if (zombieHP.enemyHP == 2){
            healthBar.size = 0.5f;
        }
        else
        {
            healthBar.size = 0.25f;
        }

        healthBar.transform.position = new Vector2(zombie.transform.position.x, zombie.transform.position.y + 0.25f);
        
    }
}
