using UnityEngine;
using UnityEngine.UI;
public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;
    private GameObject player;
    public float maxHealth;
    public float health;
    public Text healthText;
    public Slider healthSlider;
    public int coins;
    public Text coinsValue;
    private void Awake()
    {
        if (playerStats != null)
        {
            Destroy(playerStats);
        }
        else
        {
            playerStats = this;
        }
        playerStats = this;
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        player = this.gameObject;
        if (health <= 0 || health > maxHealth)
            health = maxHealth;
        SetHealthUI();
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
        SetHealthUI();
    }

    public void HealCharacter(float heal)
    {
        health += heal;
        CheckOverheal();
        SetHealthUI();
    }

    private void SetHealthUI()
    {
        healthSlider.value = CalculateHealthPercentage();
        healthText.text = health.ToString() + "/" + maxHealth.ToString();
    }
    public void CheckOverheal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    private void CheckDeath()
    {
        if (health <= 0)
        {
            health = 0;
            Destroy(player);
        }
    }

    float CalculateHealthPercentage() { return health / maxHealth; }

    public void AddCoins(int amount)
    {
        coins += amount;
        coinsValue.text = coins.ToString();
    }
}