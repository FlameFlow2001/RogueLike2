using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : UnitUI
{
    
    [SerializeField] protected GameObject manaBar;
    [SerializeField] protected Text manaValue;
    [SerializeField] protected Text healthValue;
    [SerializeField] protected Text coinValue;
    [SerializeField] protected Image firstSkillImage;
    [SerializeField] protected Image secondSkillImage;
    [SerializeField] protected Image thirdSkillImage;
    [SerializeField] protected Image ultimateImage;
    protected Slider manaBarSlider;
    
    public override void Start()
    {
        unitComponent = (PlayerComponent)unitComponent;
        if (ScriptIsSet())
        {
            healthBarSlider = healthBar.GetComponent<Slider>();
            manaBarSlider = manaBar.GetComponent<Slider>();
        }     
    }

    public void SetSkillbarUI()
    {
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
