using UnityEngine;

public class TestEnemyProjectile : MonoBehaviour
{
    public int damage;
    private GameObject player;
    private PlayerStats playerStats;
    private float lifeTime = 5f;

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
    public void Start()
    {
        Destroy(gameObject, lifeTime);
    }  
}

