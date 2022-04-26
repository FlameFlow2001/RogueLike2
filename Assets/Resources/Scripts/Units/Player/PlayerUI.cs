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
    public override void Awake()
    {
        if (ScriptIsSet())
        {
            healthBarSlider = healthBar.GetComponent<Slider>();
            manaBarSlider = manaBar.GetComponent<Slider>();
        }
    }
    private void Update()
    {
        RefreshSkillUI();
    }
    public void RefreshSkillUI()
    {
        ((PlayerComponent)unitComponent).playerSlot.firstSkill.GetComponent<Skill>().SetSkillUI();
        ((PlayerComponent)unitComponent).playerSlot.secondSkill.GetComponent<Skill>().SetSkillUI();
        ((PlayerComponent)unitComponent).playerSlot.thirdSkill.GetComponent<Skill>().SetSkillUI();
        ((PlayerComponent)unitComponent).playerSlot.ultimate.GetComponent<Skill>().SetSkillUI();
        //if (((ActiveSkill)skill).GetManacost() != 0)
        //{
        //    skillSlot.GetComponent<SkillSlotUI>().manacostText.gameObject.SetActive(true);
        //    skillSlot.GetComponent<SkillSlotUI>().manacostText.text = ((ActiveSkill)skill).GetManacost().ToString("F0");
        //}
        //else
        //    skillSlot.GetComponent<SkillSlotUI>().manacostText.gameObject.SetActive(false);

        //if (skill.isEnable)
        //{
        //    skillSlot.GetComponent<SkillSlotUI>().skillIconSlot.color = enabledSkillColor;
        //    skillSlot.GetComponent<SkillSlotUI>().cooldownText.gameObject.SetActive(false);
        //}
        //else
        //{
        //    skillSlot.GetComponent<SkillSlotUI>().skillIconSlot.color = disabledSkillColor;
        //    if (!((ActiveSkill)skill).cooldown.IsCompleted)
        //    {
        //        skillSlot.GetComponent<SkillSlotUI>().cooldownText.gameObject.SetActive(true);
        //        skillSlot.GetComponent<SkillSlotUI>().cooldownText.text = ((ActiveSkill)skill).cooldown.GetCooldownLeftTime().ToString("F1");
        //    }
        //    else
        //        skillSlot.GetComponent<SkillSlotUI>().cooldownText.gameObject.SetActive(false);
        //} 
    }

    public override void SetHealthUI(float health, float maxHealth)
    {
        healthBarSlider.value = health / maxHealth;
        healthValue.text = health.ToString() + "/" + maxHealth.ToString();
    }

    public void SetManaUI(float mana, float maxMana)
    {
        manaBarSlider.value = mana / maxMana;
        manaValue.text = Math.Floor(mana).ToString() + "/" + Math.Floor(maxMana).ToString();
    }
    public void SetCoinsUI(int coinAmount)
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
