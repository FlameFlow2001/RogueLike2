using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class UnitStats : MonoBehaviour
{
    protected UnitComponent playerComponent;
    public float maxHealth;
    public float health;
    public List<GameObject> lootDrop;
    protected GameObject player;
    protected virtual void Awake()
    {
        playerComponent = GetComponent<UnitComponent>();
    }
    protected virtual void Start()
    {
        player = GameObject.Find("Player");
        if (health <= 0 || health > maxHealth)
            health = maxHealth;
        playerComponent.unitUI.SetHealthUI(health, maxHealth);
        CheckDeath();
    }

    private void CreateDamagePopup(float takenDamage)
    {
        GameObject damagePopupCanvas = Instantiate(playerComponent.unitUI.damagePopupCanvasPref, transform.position, Quaternion.identity, transform);
        damagePopupCanvas.GetComponentInChildren<Text>().text = takenDamage.ToString();
        Vector3 randomPosOffset = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 0f);
        damagePopupCanvas.transform.position += randomPosOffset;
        Destroy(damagePopupCanvas, 3f);
    }
    public float CalculateHealthPercentage()
    {
        return (health / maxHealth);
    }

    virtual protected void CheckDeath()
    {
        if (health <= 0)
        {
            playerComponent.animator.SetTrigger("isDead");
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
        playerComponent.unitUI.healthBar.SetActive(true);
        health -= damage;
        playerComponent.unitUI.SetHealthUI(health, maxHealth);
        CheckDeath();
        CreateDamagePopup(damage);
    }

    public void HealCharacter(int heal)
    {
        health += heal;
        CheckOverheal();
        playerComponent.unitUI.SetHealthUI(health, maxHealth);
    }

    public void DropLoot()
    {
        foreach (GameObject item in lootDrop)
            Instantiate(item, transform.position, Quaternion.identity);
    }

}
