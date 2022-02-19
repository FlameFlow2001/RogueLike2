using UnityEngine;
using UnityEngine.UI;
public class PlayerProjectileScript : MonoBehaviour
{
    public float minDamage;
    public float maxDamage;
    private float lifeTime = 3f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player" && collision.tag != "Pickable" && collision.tag != "Projectile")
        {
            if (collision.GetComponent<Enemy>() != null)
            {
                float damage = Mathf.RoundToInt(Random.Range(minDamage, maxDamage));
                collision.GetComponent<Enemy>().DealDamage(damage);
            }
            //animator.Play("Projectile_Destroying");
            Destroy(gameObject, lifeTime);
        }
        Destroy(gameObject, lifeTime);
    }
}
