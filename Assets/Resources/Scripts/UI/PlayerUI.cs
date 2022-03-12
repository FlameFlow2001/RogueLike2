using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : UnitUI
{
    public Text healthValue;
    public Text coinValue;
    public override void SetHealthUI(float currentHealth, float maxHealth)
    {
        healthBarSlider.value = currentHealth / maxHealth;
        healthValue.text = currentHealth.ToString() + "/" + maxHealth.ToString();
    }

    public override void SetCoinsUI(int coinAmount)
    {
        coinValue.text = coinAmount.ToString();
    }

    protected override bool UIIsSet()
    {
        bool UISetCorrectly = base.UIIsSet();
        if (!healthValue)
        {
            Debug.Log("Health Value is not set on " + gameObject.name);
            UISetCorrectly = false;
        }
        if (!coinValue)
        {
            Debug.Log("Coin Value is not set on " + gameObject.name);
            UISetCorrectly = false;
        }
        return UISetCorrectly;
    }
}
