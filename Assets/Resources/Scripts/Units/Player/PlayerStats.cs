using UnityEngine;
using UnityEngine.UI;
public class PlayerStats : MonoBehaviour
{
    private GameObject player;
    private GameUI gameUI;
    public float maxHealth;
    public float health;
    public int coins;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    private void Start()
    {
        player = this.gameObject;
        gameUI = GameObject.Find("UI Overlay").GetComponent<GameUI>();
        if (!gameUI)
            Debug.Log("Can't find object called UI Overlay with GameUI script in scence");
        if (health <= 0 || health > maxHealth)
            health = maxHealth;
        gameUI.SetHealthUI();
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
        gameUI.SetHealthUI();
    }

    public void HealCharacter(float heal)
    {
        health += heal;
        CheckOverheal();
        gameUI.SetHealthUI();
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

    public float CalculateHealthPercentage() { return health / maxHealth; }

    public void AddCoins(int amount)
    {
        coins += amount;
        gameUI.SetCoinsUI();
    }
}