using UnityEngine;

public class Skill : MonoBehaviour
{
    protected PlayerComponent playerComponent;
    protected Vector2 playerPos;
    protected PlayerUI playerUI;
    protected PlayerStats playerStats;
    protected bool isUltimateSkill;
    [SerializeField] protected float manacost;
    [HideInInspector] public bool isEnable = true;
    [HideInInspector] public bool enoughMana = true;
    [HideInInspector] public bool onCooldown = true;
    public Sprite skillIcon;
    public Cooldown cooldown;

    public virtual void Awake()
    {
        playerComponent = gameObject.GetComponentInParent<PlayerComponent>();
        playerUI = (PlayerUI)playerComponent.unitUI;
        playerStats = (PlayerStats)playerComponent.unitStats;
        playerUI.SetSkillUI(this, playerUI.firstSkillSlot);
    }

    protected virtual void Update()
    {
        playerUI.SetSkillUI(this, playerUI.firstSkillSlot);
    }
    public float GetManacost()
    {
        return manacost;
    }
    public virtual void SetScript() { }
}
