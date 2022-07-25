
using UnityEngine;
public class EnemyStats : UnitStats
{
    public int expForKilling;
    override protected void CheckDeath()
    {
        Debug.Log(player.name);
        if (health <= 0)
        {
            playerComponent.animator.SetTrigger("isDead");
            Debug.Log(player.GetComponent<UnitStats>() != null);
            ((PlayerStats)player.GetComponent<UnitStats>()).playerLevel.AddExp(expForKilling);
            DropLoot();
        }
    }
}
