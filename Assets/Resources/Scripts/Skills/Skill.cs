using UnityEngine;

public class Skill : MonoBehaviour
{
    protected PlayerComponent playerComponent;
    protected Vector2 playerPos;
    protected PlayerUI playerUI;
    public PlayerStats playerStats;
    protected bool isUltimateSkill;
    [HideInInspector] public bool isEnable { get; protected set; }
    public Sprite skillIcon;
    protected Color32 disabledSkillColor = new Color32(255, 255, 255, 100);
    protected Color32 enabledSkillColor = new Color32(255, 255, 255, 255);


    public virtual void Start()
    {
        //isEnable = true;
        playerComponent = gameObject.GetComponentInParent<PlayerComponent>();
        playerUI = (PlayerUI)playerComponent.unitUI;
        playerStats = (PlayerStats)playerComponent.unitStats;
    }

    public virtual void SetSkillUI()
    {
        gameObject.GetComponentInParent<SkillSlot>().skillIcon.sprite = skillIcon;
        if (isEnable)
            gameObject.GetComponentInParent<SkillSlot>().skillIcon.color = enabledSkillColor;
        else
            gameObject.GetComponentInParent<SkillSlot>().skillIcon.color = disabledSkillColor;
    }
}
