using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : UnitUI
{
    
    [SerializeField] protected GameObject manaBar;
    [SerializeField] protected GameObject expBar;
    [SerializeField] protected Text manaValue;
    [SerializeField] protected Text healthValue;
    [SerializeField] protected Text coinValue;
    public GameObject firstSkillSlot;
    public GameObject secondSkillSlot;
    public GameObject thirdSkillSlot;
    public GameObject ultimateSlot;
    protected Slider manaBarSlider;
    protected Slider expBarSlider;
    public override void Awake()
    {
        if (ScriptIsSet())
        {
            healthBarSlider = healthBar.GetComponent<Slider>();
            manaBarSlider = manaBar.GetComponent<Slider>();
            expBarSlider = expBar.GetComponent<Slider>();
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
        ((PlayerComponent)unitComponent).playerSlot.dash.GetComponent<Dash>().SetSkillUI();
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

    public void SetExpUI(float currentExp, float expToPrevLvl, float expToNextLvl)
    {
        expBarSlider.value = (currentExp - expToPrevLvl) / (expToNextLvl - expToPrevLvl);
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
