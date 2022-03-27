using UnityEngine;


public class TripletWeapon : BasicWeaponScript
{
    override public void Attack(Vector2 weaponOwnerPos, Vector2 attackingDirection)
    {
        GameObject newProjectile = Instantiate(projectile, weaponOwnerPos, Quaternion.identity);
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
        rb.AddForce(attackingDirection * projectileForce);

        GameObject newProjectile1 = Instantiate(projectile, weaponOwnerPos, Quaternion.identity);
        Rigidbody2D rb1 = newProjectile1.GetComponent<Rigidbody2D>();
        Vector2 shootingDirection1 = attackingDirection;
        shootingDirection1.x = attackingDirection.x * Mathf.Cos(Mathf.PI / 6) - attackingDirection.y * Mathf.Sin(Mathf.PI / 6);
        shootingDirection1.y = attackingDirection.x * Mathf.Sin(Mathf.PI / 6) + attackingDirection.y * Mathf.Cos(Mathf.PI / 6);
        rb1.AddForce(shootingDirection1 * projectileForce);

        GameObject newProjectile2 = Instantiate(projectile, weaponOwnerPos, Quaternion.identity);
        Rigidbody2D rb2 = newProjectile2.GetComponent<Rigidbody2D>();
        Vector2 shootingDirection2 = attackingDirection;
        shootingDirection2.x = attackingDirection.x * Mathf.Cos(-Mathf.PI / 6) - attackingDirection.y * Mathf.Sin(-Mathf.PI / 6);
        shootingDirection2.y = attackingDirection.x * Mathf.Sin(-Mathf.PI / 6) + attackingDirection.y * Mathf.Cos(-Mathf.PI / 6);
        rb2.AddForce(shootingDirection2 * projectileForce);
    }

}