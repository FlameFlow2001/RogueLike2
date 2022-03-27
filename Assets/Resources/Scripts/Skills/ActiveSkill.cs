using UnityEngine;
public class ActiveSkill : Skill
{
    [SerializeField] protected float manacost;
    [SerializeField] protected Cooldown cooldown;
    protected virtual void ActiveEffect() {}
    public void TryToUseSkill()
    {
        if (playerStats.mana > manacost && cooldown.IsCompleted)
        {
            playerPos = player.transform.position;
            ActiveEffect();
            playerStats.mana -= manacost;
            playerUI.SetManaUI(playerStats.mana, playerStats.maxMana);
            cooldown.StartCooldown();

        }
    }
}
