using UnityEngine;

public class StandartWeapon : BasicWeaponScript
{
    override protected void Shoot()
    {
        shootingDirection = ShootingDirectionCalculating();
        GameObject newProjectile = Instantiate(projectile, weaponOwnerPos, Quaternion.identity);
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
        rb.AddForce(shootingDirection * projectileForce);
    }

}
