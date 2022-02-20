using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPPotion : MonoBehaviour
{
    public int healValue;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            PlayerStats.playerStats.HealCharacter(healValue);
        Destroy(gameObject);
    }
}
