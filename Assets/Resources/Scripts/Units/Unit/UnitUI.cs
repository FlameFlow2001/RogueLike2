using UnityEngine;
using UnityEngine.UI;

public class UnitUI : MonoBehaviour
{
    public UnitComponent unitComponent;
    public GameObject damagePopupCanvasPref;
    public GameObject healthBar;
    protected Slider healthBarSlider;

    virtual public void Awake()
    {
        if (ScriptIsSet())
            healthBarSlider = healthBar.GetComponent<Slider>();
    }
    public virtual void SetHealthUI(float health, float maxHealth)
    {
        if (healthBarSlider)
            healthBarSlider.value = health / maxHealth;
    }
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
