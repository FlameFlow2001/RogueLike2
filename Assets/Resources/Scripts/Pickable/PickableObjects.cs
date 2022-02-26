using UnityEngine;

public class PickableObjects : MonoBehaviour
{
    protected GameObject player;
    protected PlayerStats playerStats;
    virtual protected void PickingUp() { }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player = other.gameObject;
            playerStats = player.GetComponent<PlayerStats>();
            PickingUp();
            Destroy(gameObject);
        }
    }
}