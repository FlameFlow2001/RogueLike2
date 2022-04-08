using UnityEngine;
public class ActiveSkill : Skill
{
    [SerializeField] protected float manacost;
    [SerializeField] protected Cooldown cooldown;
    public void TryToUseSkill()
    {
        if (playerStats.mana > manacost && cooldown.IsCompleted)
        {
            playerPos = playerComponent.transform.position;
            ActiveEffect();
            playerStats.mana -= manacost;
            playerUI.SetManaUI(playerStats.mana, playerStats.maxMana);
            cooldown.StartCooldown();

        }
    }
}
