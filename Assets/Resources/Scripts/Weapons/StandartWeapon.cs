using UnityEngine;

public class StandartWeapon : BasicWeaponScript
{
    override public void Attack(Vector2 weaponOwnerPos, Vector2 attackingDirection)
    {
        GameObject newProjectile = Instantiate(projectile, weaponOwnerPos, Quaternion.identity);
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
        rb.AddForce(attackingDirection * projectileForce);
    }
}
