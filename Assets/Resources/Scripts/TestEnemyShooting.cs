using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TestEnemyShooting : EnemyAttack
{
    public GameObject projectile;
    public float minDamage;
    public float maxDamage;
    public float projectileForce;
    public float cooldown;
    public float shootingDelay;

    public override void Start()
    {
        base.Start();
        GameObject Player = GameObject.Find("Player");
        target = Player.transform;
        StartCoroutine(ShootPlayer());
    }
    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(cooldown);
        if (target != null)
        {
            Vector2 myPos = transform.position;
            Vector2 targetPos = target.position;
            Vector2 direction = (targetPos - myPos).normalized;
            yield return new WaitForSeconds(shootingDelay);
            GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            spell.GetComponent<TestEnemyProjectile>().damage = Mathf.Ceil(Random.Range(minDamage, maxDamage));
            StartCoroutine(ShootPlayer());
        }

    }
}
