public class ActiveSkill : Skill
{
    protected virtual void ActiveEffect() { }

    protected override void Update()
    {
        enoughMana = playerStats.mana > manacost;
        isEnable = enoughMana && cooldown.IsCompleted;
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
