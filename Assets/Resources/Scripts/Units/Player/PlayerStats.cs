using UnityEngine;
public class PlayerStats : UnitStats
{
    protected int coins;
    public PlayerLevel playerLevel;
    public float mana;
    public float maxMana;
    public float manaRegenPerSec;
    protected override void Awake()
    {
        playerComponent = GetComponent<UnitComponent>();
        DontDestroyOnLoad(this);
    }
    protected override void Start()
    {
        if (health <= 0 || health > maxHealth)
            health = maxHealth;
        playerComponent.unitUI.SetHealthUI(health, maxHealth);
        ((PlayerUI)playerComponent.unitUI).SetManaUI(mana, maxMana);
        CheckDeath();
    }

    public void Update()
    {
        if (mana < maxMana)
        {
            mana += manaRegenPerSec * Time.deltaTime;
            ((PlayerUI)playerComponent.unitUI).SetManaUI(mana, maxMana);
        }
        
        if (mana > maxMana)
        {
            mana = maxMana;
            ((PlayerUI)playerComponent.unitUI).SetManaUI(mana, maxMana);
        }
    }


    public void AddCoins(int amount)
    {
        coins += amount;
        ((PlayerUI)playerComponent.unitUI).SetCoinsUI(amount);
    }
}