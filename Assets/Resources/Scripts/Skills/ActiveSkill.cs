using UnityEngine;
public class ActiveSkill : Skill
{
    [SerializeField] protected float manacost;
    [SerializeField] protected Cooldown cooldown;

    protected virtual void ActiveEffect() { }

    protected override void Update()
    {
        isEnable = playerStats.mana > manacost && cooldown.IsCompleted;
        playerUI.SetSkillUI(this, playerUI.firstSkillSlot);
    }
    public void TryToUseSkill()
    {
        if (isEnable)
        {
            playerPos = playerComponent.transform.position;
            ActiveEffect();
            playerStats.mana -= manacost;
            cooldown.StartCooldown();
        }
    }
}
