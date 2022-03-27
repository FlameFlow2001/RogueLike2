using UnityEngine;

public class PickableObjects : TriggeredObjects
{
    protected GameObject player;
    protected PlayerStats playerStats;
    protected PlayerSlot playerSlot;
    virtual protected void PickingUpEffect() { }

    override protected void TriggerEffect(GameObject triggerer)
    {
        if (triggerer.tag == "Player")
        {
            player = triggerer;
            playerStats = player.GetComponent<PlayerStats>();
            playerSlot = player.GetComponent<PlayerComponent>().playerSlot;
            PickingUpEffect();
            Destroy(gameObject);
        }
    }


}