using UnityEngine;
using System.Collections;

public class PlayerProjectileScript : MonoBehaviour
{
    public int minDamage;
    public int maxDamage;
    private float lifeTime = 3f;
    private Animator animator;
    private EnemyStats enemy;
    public void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player" && collision.tag != "Pickable" && collision.tag != "Projectile")
        {
            if (collision.GetComponent<EnemyStats>() != null)
            {
                int damage = Mathf.RoundToInt(Random.Range(minDamage, maxDamage));
                enemy = collision.GetComponent<EnemyStats>();
                enemy.DealDamage(damage);
            }
            animator.Play("ProjectileDestroying");
        }

        IEnumerator DestroyProjectile()
        {
            yield return new WaitForSeconds(lifeTime);
            animator.Play("ProjectileDestroying");
        }
        StartCoroutine(DestroyProjectile());
    }
}
