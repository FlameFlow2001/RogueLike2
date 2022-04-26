using UnityEngine;
public class PlayerStats : UnitStats
{
    protected int coins;
    public float mana;
    public float maxMana;
    public float manaRegenPerSec;
    protected void Awake()
    {
        DontDestroyOnLoad(this);
    }
    protected override void Start()
    {
        if (health <= 0 || health > maxHealth)
            health = maxHealth;
        unitComponent.unitUI.SetHealthUI(health, maxHealth);
        ((PlayerUI)unitComponent.unitUI).SetManaUI(mana, maxMana);
        CheckDeath();
    }

    public void Update()
    {
        if (mana < maxMana)
        {
            mana += manaRegenPerSec * Time.deltaTime;
            ((PlayerUI)unitComponent.unitUI).SetManaUI(mana, maxMana);
        }
    }
    public void AddCoins(int amount)
    {
        coins += amount;
        ((PlayerUI)unitComponent.unitUI).SetCoinsUI(amount);
    }
}