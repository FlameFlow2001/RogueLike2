using UnityEngine;

public class Skill : MonoBehaviour
{
    protected PlayerComponent playerComponent;
    protected Vector2 playerPos;
    protected PlayerUI playerUI;
    protected PlayerStats playerStats;
    protected bool isUltimateSkill;
    public Sprite skillIcon;

    public virtual void Awake()
    {
        playerComponent = gameObject.GetComponentInParent<PlayerComponent>();
        playerUI = (PlayerUI)playerComponent.unitUI;
        playerStats = (PlayerStats)playerComponent.unitStats;
    }

    public virtual void SetScript() { }
    protected virtual void ActiveEffect() { }
    //public virtual void TryToUseSkill() { }
}
