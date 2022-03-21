using UnityEngine;
public class ActiveSkill : Skill
{
    [SerializeField] protected float manacost;
    [SerializeField] protected Cooldown cooldown;
    [SerializeField] protected KeyCode bindedKey;
    protected virtual void ActiveEffect() {}
    private void Update()
    {
        if (Input.GetKeyDown(bindedKey))
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
}
