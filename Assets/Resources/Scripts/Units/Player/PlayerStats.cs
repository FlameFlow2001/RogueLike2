using UnityEngine;
public class PlayerStats : UnitStats
{
    protected int coins;
    public float mana;
    public float maxMana;
    public float manaRegenPerSec;
    protected override void Start()
    {
        if (health <= 0 || health > maxHealth)
            health = maxHealth;
        unitComponent.unitUI.SetHealthUI(health, maxHealth);
        unitComponent.unitUI.SetManaUI(mana, maxMana);
        CheckDeath();
    }

    public void Update()
    {
        if (mana < maxMana)
        {
            mana += manaRegenPerSec * Time.deltaTime;
            unitComponent.unitUI.SetManaUI(mana, maxMana);
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        unitComponent.unitUI.SetCoinsUI(amount);
    }

}