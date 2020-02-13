using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text ammoText;
    public Text healthText;
    public GunScript gun;
    public PlayerHealth playerHP;

    // Update is called once per frame
    void Update()
    {
        ammoText.text = "AMMO: " + gun.bulletClip + " | " + gun.maxClip;
        healthText.text = "HP:       x" + playerHP.playerHP;
    }
}
