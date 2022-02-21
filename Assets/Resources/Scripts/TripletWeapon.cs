using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TripletWeapon : BasicWeaponScript
{
    override protected void Shoot()
    {
        shootingDirection = ShootingDirectionCalculating();

        GameObject newProjectile = Instantiate(projectile, weaponOwnerPos, Quaternion.identity);
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
        rb.AddForce(shootingDirection * projectileForce);

        GameObject newProjectile1 = Instantiate(projectile, weaponOwnerPos, Quaternion.identity);
        Rigidbody2D rb1 = newProjectile1.GetComponent<Rigidbody2D>();
        Vector2 shootingDirection1 = shootingDirection;
        shootingDirection1.x = shootingDirection.x * Mathf.Cos(Mathf.PI / 6) - shootingDirection.y * Mathf.Sin(Mathf.PI / 6);
        shootingDirection1.y = shootingDirection.x * Mathf.Sin(Mathf.PI / 6) + shootingDirection.y * Mathf.Cos(Mathf.PI / 6);
        rb1.AddForce(shootingDirection1 * projectileForce);

        GameObject newProjectile2 = Instantiate(projectile, weaponOwnerPos, Quaternion.identity);
        Rigidbody2D rb2 = newProjectile2.GetComponent<Rigidbody2D>();
        Vector2 shootingDirection2 = shootingDirection;
        shootingDirection2.x = shootingDirection.x * Mathf.Cos(-Mathf.PI / 6) - shootingDirection.y * Mathf.Sin(-Mathf.PI / 6);
        shootingDirection2.y = shootingDirection.x * Mathf.Sin(-Mathf.PI / 6) + shootingDirection.y * Mathf.Cos(-Mathf.PI / 6);
        rb2.AddForce(shootingDirection2 * projectileForce);
    }

}