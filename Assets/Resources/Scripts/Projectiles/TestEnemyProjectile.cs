using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyProjectile : MonoBehaviour
{
    public float damage;
    private GameObject player;
    private PlayerStats playerStats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Enemy" && collision.tag != "Pickable")
        {
            if (collision.tag == "Player")
            {
                player = collision.gameObject;
                playerStats = player.GetComponent<PlayerStats>();
                playerStats.DealDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}

