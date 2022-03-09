using System.Collections;
using System.Collections.Generic;
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
        target = GameObject.Find("Player").transform;
        StartCoroutine(ShootPlayer());
    }
    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(cooldown);
        if (target != null)
        {
            Vector2 attackDirection = GetAttackDirection(transform.position, target.position);
            yield return new WaitForSeconds(shootingDelay);
            GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            spell.GetComponent<Rigidbody2D>().velocity = attackDirection * projectileForce;
            spell.GetComponent<TestEnemyProjectile>().damage = Mathf.CeilToInt(Random.Range(minDamage, maxDamage));
            StartCoroutine(ShootPlayer());
        }

    }
}
