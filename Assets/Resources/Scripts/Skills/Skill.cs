using UnityEngine;

public class Skill : MonoBehaviour
{
    [SerializeField] protected GameObject player;
    protected Vector2 playerPos;
    protected PlayerUI playerUI;
    protected PlayerStats playerStats;
    protected bool isUltimateSkill;
    protected virtual void Start()
    {
        SetScript();
    }

    protected virtual void SetScript()
    {
        playerUI = player.GetComponent<PlayerUI>();
        playerStats = player.GetComponent<PlayerStats>();
    }
}
