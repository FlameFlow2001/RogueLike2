using UnityEngine;
public class ActiveSkill : Skill
{
    [SerializeField] protected float manacost = 0;
    private bool enoughMana = true;
    public Cooldown cooldown;
    protected virtual void ActiveEffect() { }
    public float GetManacost()
    {
        return manacost;
    }

    protected virtual void Update()
    {
        enoughMana = playerStats.mana > manacost;
        isEnable = enoughMana && cooldown.IsCompleted;
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

    public override void SetSkillUI()
    {
        gameObject.GetComponentInParent<SkillSlot>().skillIcon.sprite = skillIcon;
        if (manacost != 0)
        {
            gameObject.GetComponentInParent<SkillSlot>().manacostText.gameObject.SetActive(true);
            gameObject.GetComponentInParent<SkillSlot>().manacostText.text = manacost.ToString("F0");
        }
        else
            gameObject.GetComponentInParent<SkillSlot>().manacostText.gameObject.SetActive(false);

        if (isEnable)
        {
            gameObject.GetComponentInParent<SkillSlot>().skillIcon.color = enabledSkillColor;
            gameObject.GetComponentInParent<SkillSlot>().cooldownText.gameObject.SetActive(false);
        }
        else
        {
            gameObject.GetComponentInParent<SkillSlot>().skillIcon.color = disabledSkillColor;
            if (!cooldown.IsCompleted)
            {
                gameObject.GetComponentInParent<SkillSlot>().cooldownText.gameObject.SetActive(true);
                gameObject.GetComponentInParent<SkillSlot>().cooldownText.text = cooldown.GetCooldownLeftTime().ToString("F1");
            }
            else
                gameObject.GetComponentInParent<SkillSlot>().cooldownText.gameObject.SetActive(false);
        }
    }
}