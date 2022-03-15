using UnityEngine;
public class PlayerStats : Units
{
    
    protected int coins;
    public float mana;
    public float maxMana;

    protected override void Start()
    {
        UI = gameObject.GetComponent<PlayerUI>();
        animator = gameObject.GetComponent<Animator>();
        ScriptIsSet();
        if (health <= 0 || health > maxHealth)
            health = maxHealth;
        UI.SetHealthUI(health, maxHealth);
        UI.SetManaUI(mana, maxMana);
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

    protected override bool ScriptIsSet()
    {
        bool scriptSetCorrectly = true;
        if (!animator)
        {
            Debug.Log("Animator is not found on " + gameObject.name);
            scriptSetCorrectly = false;
        }
        if (!UI)
        {
            Debug.Log("PlayerUI script is not found on " + gameObject.name);
            scriptSetCorrectly = false;
        }
        return scriptSetCorrectly;
    }
}