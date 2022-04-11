using UnityEngine;

public class Skill : MonoBehaviour
{
    protected PlayerComponent playerComponent;
    protected Vector2 playerPos;
    protected PlayerUI playerUI;
    protected PlayerStats playerStats;
    protected bool isUltimateSkill;
    public bool isEnable;
    public Sprite skillIcon;

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
        if (isEnable)
            Debug.Log("Enabled");
        else
            Debug.Log("Disabled");
    }

    public virtual void SetScript() { }
}
