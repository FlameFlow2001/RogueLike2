using UnityEngine;

public class BasicWeaponScript : AttackScript
{
    protected Transform weaponOwnerTransform;
    protected Vector2 weaponOwnerPos;
    protected Vector2 attackingDirection;
    [SerializeField] protected GameObject projectile;
    [SerializeField] protected float projectileForce = 0.1f;
    [SerializeField] private Cooldown cooldown;
    private void Start()
    {
        weaponOwnerTransform = GetComponentInParent<Transform>().parent;
    }
    protected Vector2 AttackingDirectionCalculating()
    {
        if (weaponOwnerTransform != null)
        {
            Vector2 mousePos2D = Input.mousePosition;
            var screenToCameraDistance = Camera.main.nearClipPlane;
            var mousePosNearClipPlane = new Vector3(mousePos2D.x, mousePos2D.y, screenToCameraDistance);
            Vector2 worldPointPos = Camera.main.ScreenToWorldPoint(mousePosNearClipPlane);
            weaponOwnerPos = weaponOwnerTransform.transform.position;
            Vector2 calculatedShootingDirection = (worldPointPos - weaponOwnerPos).normalized;
            return calculatedShootingDirection;
        }
        else
            return Vector2.zero;
    }

    public void Update()
    {
        if (Input.GetMouseButton(1) && cooldown.IsCompleted)
        {
            attackingDirection = AttackingDirectionCalculating();
            Attack();
            cooldown.StartCooldown();
        }        
    }

}
