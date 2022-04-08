using UnityEngine;

public class CircleHit : ActiveSkill
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private float angleBetweenProjectiles;
    [SerializeField] private float projectileForce;
    protected override void ActiveEffect()
    {
        float projectileShootingAngle = 0;
        while (projectileShootingAngle < 360)
        {
            CreateProjectileAndShoot(projectileShootingAngle);
            projectileShootingAngle += angleBetweenProjectiles;
        }
    }
    private void CreateProjectileAndShoot(float angle)
    {
        Vector2 attackingDirection;
        attackingDirection.x = Vector2.up.x * Mathf.Cos(angle * Mathf.Deg2Rad) - Vector2.up.y * Mathf.Sin(angle * Mathf.Deg2Rad);
        attackingDirection.y = Vector2.up.x * Mathf.Sin(angle * Mathf.Deg2Rad) + Vector2.up.y * Mathf.Cos(angle * Mathf.Deg2Rad);
        GameObject newProjectile = Instantiate(projectile, playerPos, Quaternion.identity);
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
        rb.AddForce(attackingDirection.normalized * projectileForce);
    }
}
