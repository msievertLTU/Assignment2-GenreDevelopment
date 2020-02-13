using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float playerHP = 3;

    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerHP -= 1;
        }
    }

    void DestroyPlayer()
    {
        Destroy(player);
        SceneManager.LoadScene("GameOver");
    }

    void Update()
    {
        if (playerHP <= 0)
        {
            DestroyPlayer();
        }
    }
}
