using UnityEngine;
using UnityEngine.UI;

public class UnitUI : MonoBehaviour
{
    public GameObject damagePopupCanvasPref;
    public GameObject healthBar;
    protected Slider healthBarSlider;

    virtual public void Start()
    {
        if (ScriptIsSet())
            healthBarSlider = healthBar.GetComponent<Slider>();
    }
    public virtual void SetHealthUI(float health, float maxHealth)
    {
        if (healthBarSlider)
            healthBarSlider.value = health / maxHealth;
    }

    public virtual void SetCoinsUI(int coinAmount) { } //Necessary for PlayerUI script working
    public virtual void SetManaUI(float mana, float maxMana) { } //Necessary for PlayerUI script working

    protected virtual bool ScriptIsSet() 
    {
        bool scriptSetCorrectly = true;
        if (!healthBar)
        {
            Debug.Log("Health Bar is not set on " + gameObject.name);
            scriptSetCorrectly = false;
        }
        if (!damagePopupCanvasPref)
        {
            Debug.Log("Damage Popup Canvas Prefab is not set on " + gameObject.name);
            scriptSetCorrectly = false;
        }
        return scriptSetCorrectly;
    }
}
