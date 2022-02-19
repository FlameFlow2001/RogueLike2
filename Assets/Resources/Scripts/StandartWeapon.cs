using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartWeapon : BasicWeaponScript
{
    override public void Shoot()
    {
        shootingDirection = ShootingDirectionCalculating();
        GameObject newProjectile = Instantiate(projectile, weaponOwnerPos.transform.position, Quaternion.identity);
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
        rb.AddForce(shootingDirection * projectileForce);
    }

}
