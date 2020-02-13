using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float playerHP = 3;

    public Text playerhptext;
    public GameObject player;

    void Start()
    {
        playerhptext.text = "HP:       x" + playerHP;
    }

    public void updateHPUI()
    {
        playerhptext.text = "HP:       x" + playerHP;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerHP -= 1;
            playerhptext.text = "HP:       x" + playerHP;
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
