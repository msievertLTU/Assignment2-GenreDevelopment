using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMovement : MonoBehaviour
{
    public float levelSpeed = 2;
    public GameObject level;
    
    public void MoveLevel()
    {
        float levelMovement = levelSpeed * Time.deltaTime;
        level.transform.position = new Vector2(level.transform.position.x, level.transform.position.y - levelMovement);
    }

    void Update()
    {
        MoveLevel();
    }
}
