using UnityEngine;
using UnityEngine.UI;

public class UnitUI : MonoBehaviour
{
    public GameObject damagePopupCanvasPref;
    public GameObject healthBar;
    [HideInInspector] public Slider healthBarSlider;

    public void Start()
    {
        if (healthBar)
            healthBarSlider = healthBar.GetComponent<Slider>();
        else
            Debug.Log("Health Bar is not set on " + gameObject.name);
        if (!damagePopupCanvasPref)
            Debug.Log("Damage Popup Canvas Prefab is not set on " + gameObject.name);
    }
    public virtual void SetHealthUI(float currentHealth, float maxHealth)
    {
        healthBarSlider.value = currentHealth / maxHealth;
    }

    public virtual void SetCoinsUI(int coinAmount) { } //Necessary for PlayerUI script working
}
