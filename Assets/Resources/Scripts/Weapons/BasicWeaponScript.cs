using UnityEngine;

public class BasicWeaponScript : AttackScript
{
    [SerializeField] protected GameObject projectile;
    [SerializeField] protected float projectileForce = 0.1f;
    [SerializeField] private Cooldown cooldown;
    private Vector2 weaponOwnerPos;

    public virtual void TryToAttack(Vector2 ownerPos, Vector2 attackDirection)
    {
        if (cooldown.IsCompleted)
        {
            weaponOwnerPos = ownerPos;
            cooldown.StartCooldown();
            Attack(weaponOwnerPos, attackDirection);

        }
    }

}
