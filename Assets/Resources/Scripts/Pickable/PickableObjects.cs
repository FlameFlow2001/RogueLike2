using UnityEngine;

public class PickableObjects : TriggeredObjects
{
    protected GameObject player;
    protected PlayerStats playerStats;
    virtual protected void PickingUpEffect() { }

    override protected void TriggerEffect(GameObject triggerer)
    {
        if (triggerer.tag == "Player")
        {
            player = triggerer;
            playerStats = player.GetComponent<PlayerStats>();
            PickingUpEffect();
            Destroy(gameObject);
        }
    }


}