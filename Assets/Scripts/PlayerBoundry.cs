using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundry : MonoBehaviour
{
    public Transform camera;
    public Transform player;

    public void CheckPlayerPosition()
    {
        PlayerMovement playerSpeed = player.GetComponent<PlayerMovement>();

        if (player.position.y <= camera.position.y - 5)
        {
            player.position = new Vector2(player.position.x, player.position.y + playerSpeed.playerSpeed * Time.deltaTime);
        }
        if (player.position.y >= camera.position.y + 5)
        {
            player.position = new Vector2(player.position.x, player.position.y - playerSpeed.playerSpeed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerPosition();
    }
}
