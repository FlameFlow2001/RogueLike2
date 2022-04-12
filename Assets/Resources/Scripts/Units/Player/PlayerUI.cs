using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : UnitUI
{
    
    [SerializeField] protected GameObject manaBar;
    [SerializeField] protected Text manaValue;
    [SerializeField] protected Text healthValue;
    [SerializeField] protected Text coinValue;
    public GameObject firstSkillSlot;
    public GameObject secondSkillSlot;
    public GameObject thirdSkillSlot;
    public GameObject ultimateSlot;
    protected Slider manaBarSlider;
    private Color32 disabledSkillColor = new Color32(255,255,255,100);
    private Color32 enabledSkillColor = new Color32(255,255,255,255);
    
    public override void Start()
    {
        unitComponent = (PlayerComponent)unitComponent;
        if (ScriptIsSet())
        {
            healthBarSlider = healthBar.GetComponent<Slider>();
            manaBarSlider = manaBar.GetComponent<Slider>();
        }     
    }
    public void SetSkillUI(Skill skill, GameObject skillSlot)
    {
        skillSlot.GetComponent<SkillSlotUI>().skillIconSlot.sprite = skill.skillIcon;
        if (skill.GetManacost() != 0)
            skillSlot.GetComponent<SkillSlotUI>().manacostText.text = skill.GetManacost().ToString("F0");
        if (skill.isEnable)
        {
            skillSlot.GetComponent<SkillSlotUI>().skillIconSlot.color = enabledSkillColor;
            skillSlot.GetComponent<SkillSlotUI>().cooldownText.gameObject.SetActive(false);
        }
        else
        {
            if (!skill.cooldown.IsCompleted)
            {
                skillSlot.GetComponent<SkillSlotUI>().skillIconSlot.color = disabledSkillColor;
                skillSlot.GetComponent<SkillSlotUI>().cooldownText.gameObject.SetActive(true);
                skillSlot.GetComponent<SkillSlotUI>().cooldownText.text = skill.cooldown.GetCooldownLeftTime().ToString("F1");
            }
            else
                skillSlot.GetComponent<SkillSlotUI>().cooldownText.gameObject.SetActive(false);
        } 
    }

    public override void SetHealthUI(float health, float maxHealth)
    {
        healthBarSlider.value = health / maxHealth;
        healthValue.text = health.ToString() + "/" + maxHealth.ToString();
    }

    public override void SetManaUI(float mana, float maxMana)
    {
        manaBarSlider.value = mana / maxMana;
        manaValue.text = Math.Round(mana).ToString() + "/" + Math.Round(maxMana).ToString();
    }
    public override void SetCoinsUI(int coinAmount)
    {
        coinValue.text = coinAmount.ToString();
    }

    protected override bool ScriptIsSet()
    {
        bool scriptSetCorrectly = base.ScriptIsSet();
        if (!healthValue)
        {
            Debug.Log("Health value is not set on " + gameObject.name);
            scriptSetCorrectly = false;
        }
        if (!coinValue)
        {
            Debug.Log("Coin value is not set on " + gameObject.name);
            scriptSetCorrectly = false;
        }
        if (!manaBar)
        {
            Debug.Log("Mana bar is not set on " + gameObject.name);
            scriptSetCorrectly = false;
        }
        if (!manaValue)
        {
            Debug.Log("Mana value is not set on " + gameObject.name);
            scriptSetCorrectly = false;
        }
        return scriptSetCorrectly;
    }
}
