using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Units : MonoBehaviour
{
    public float maxHealth;
    public float health;
    public List<GameObject> lootDrop;
    protected UnitUI UI;
    protected virtual void Start()
    {
        UI = gameObject.GetComponent<UnitUI>();
        if (!UI)
            Debug.Log("UnitUI script on " + gameObject.name + " is not found");
        if (health <= 0 || health > maxHealth)
            health = maxHealth;
        UI.SetHealthUI(health, maxHealth);
        CheckDeath();
    }

    private void CreateDamagePopup(float takenDamage)
    {
        GameObject damagePopupCanvas = Instantiate(UI.damagePopupCanvasPref, transform.position, Quaternion.identity, transform);
        damagePopupCanvas.GetComponentInChildren<Text>().text = takenDamage.ToString();
        Vector3 randomPosOffset = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 0f);
        damagePopupCanvas.transform.position += randomPosOffset;
        Destroy(damagePopupCanvas, 3f);
    }
    public float CalculateHealthPercentage()
    {
        return (health / maxHealth);
    }

    protected void CheckDeath()
    {
        if (health <= 0)
        {
            health = 0;
            Destroy(gameObject);
            DropLoot();
        }
    }

    protected void CheckOverheal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    public void DealDamage(int damage)
    {
        UI.healthBar.SetActive(true);
        health -= damage;
        UI.SetHealthUI(health, maxHealth);
        CheckDeath();
        if (UI.damagePopupCanvasPref != null)
        {
            CreateDamagePopup(damage);
        }
    }

    public void HealCharacter(int heal)
    {
        health += heal;
        CheckOverheal();
        UI.healthBarSlider.value = CalculateHealthPercentage();
    }

    public void DropLoot()
    {
        foreach (GameObject item in lootDrop)
            Instantiate(item, transform.position, Quaternion.identity);
    }
}
