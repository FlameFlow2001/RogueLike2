using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public GameObject damagePopupCanvasPref;
    public GameObject healthBar;
    public Slider healthBarSlider;
    public float maxHealth;
    public float health;
    public GameObject lootDrop;
    public void Start()
    {
        if (health <= 0 || health > maxHealth)
            health = maxHealth;
    }

    private void CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(lootDrop, transform.position, Quaternion.identity);
        }
    }
    private void CreateDamagePopup(float takenDamage)
    {
        GameObject damagePopupCanvas = Instantiate(damagePopupCanvasPref, transform.position, Quaternion.identity, transform);
        damagePopupCanvas.GetComponentInChildren<Text>().text = takenDamage.ToString();
        Vector3 randomPosOffset = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 0f);
        damagePopupCanvas.transform.position += randomPosOffset;
    }
    public void DealDamage(float damage)
    {
        healthBar.SetActive(true);
        health -= damage;
        CheckDeath();
        healthBarSlider.value = CalculateHealthPercentage();
        if (damagePopupCanvasPref != null && health > 0)
        {
            CreateDamagePopup(damage);
        }
        
    }

    public void CheckOverheal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    public void HealCharacter(float heal)
    {
        health += heal;
        CheckOverheal();
        healthBarSlider.value = CalculateHealthPercentage();
    }

    private float CalculateHealthPercentage()
    {
        return (health / maxHealth);
    }
}
