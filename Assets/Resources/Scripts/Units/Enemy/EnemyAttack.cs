using UnityEngine;

public class EnemyAttack : AttackScript
{
    public Transform target;
    [SerializeField] protected float cooldown;

    public virtual void Start()
    {
        target = GameObject.Find("Player").transform;
        if (!target)
            Debug.Log("Target is not found");
    }

    protected Vector2 GetAttackDirection(Vector2 attackerPos, Vector2 targetPos)
    {
        return (targetPos - attackerPos).normalized;
    }
}
