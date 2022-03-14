using UnityEngine;
using UnityEngine.UI;

public class UnitUI : MonoBehaviour
{
    public GameObject damagePopupCanvasPref;
    public GameObject healthBar;
    [HideInInspector] public Slider healthBarSlider;

    public void Start()
    {
        if (UIIsSet())
            healthBarSlider = healthBar.GetComponent<Slider>();
    }
    public virtual void SetHealthUI(float health, float maxHealth)
    {
        if (healthBarSlider)
            healthBarSlider.value = health / maxHealth;
    }

    public virtual void SetCoinsUI(int coinAmount) { } //Necessary for PlayerUI script working

    protected virtual bool UIIsSet() 
    {
        bool UISetCorrectly = true;
        if (!healthBar)
        {
            Debug.Log("Health Bar is not set on " + gameObject.name);
            UISetCorrectly = false;
        }
        if (!damagePopupCanvasPref)
        {
            Debug.Log("Damage Popup Canvas Prefab is not set on " + gameObject.name);
            UISetCorrectly = false;
        }
        return UISetCorrectly;
    }
}
