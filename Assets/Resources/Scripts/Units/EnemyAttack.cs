using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    protected Transform target;
    public int minDamage;
    public int maxDamage;
    public float cooldown;

    public virtual void Start()
    {
        target = GameObject.Find("Player").transform;
        if (!target)
            Debug.Log("Target for enemies is not found");
    }

    protected Vector2 GetAttackDirection(Vector2 attackerPos, Vector2 targetPos)
    {
        return (targetPos - attackerPos).normalized;
    }
}
