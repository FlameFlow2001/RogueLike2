using System.Collections;
using UnityEngine;
public class EnemyShooting : EnemyAttack
{
    public GameObject projectile;
    public float projectileForce;
    public float shootingDelay;
    public int minDamage;
    public int maxDamage;

    public override void Start()
    {
        base.Start();
        StartCoroutine(ShootPlayer());
    }
    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(cooldown);
        if (target != null)
        {
            Vector2 attackDirection = GetAttackDirection(transform.position, target.position);
            yield return new WaitForSeconds(shootingDelay);
            GameObject enemyProjectile = Instantiate(projectile, transform.position, Quaternion.identity);
            enemyProjectile.GetComponent<Rigidbody2D>().velocity = attackDirection * projectileForce;
            enemyProjectile.GetComponent<TestEnemyProjectile>().damage = Mathf.CeilToInt(Random.Range(minDamage, maxDamage));
            StartCoroutine(ShootPlayer());
        }

    }
}
