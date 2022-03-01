using UnityEngine;
public class PlayerStats : Units
{
    
    public int coins;

    protected override void Start()
    {
        UI = gameObject.GetComponent<PlayerUI>();
        if (!UI)
            Debug.Log("PlayerUI script on " + gameObject.name + " is not found");
        if (health <= 0 || health > maxHealth)
            health = maxHealth;
        UI.SetHealthUI(health, maxHealth);
        CheckDeath();
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        UI.SetCoinsUI(amount);
    }
}