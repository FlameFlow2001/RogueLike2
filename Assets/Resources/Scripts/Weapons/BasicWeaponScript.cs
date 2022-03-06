using UnityEngine;

public class BasicWeaponScript : MonoBehaviour
{
    protected Transform weaponOwnerTransform;
    protected Vector2 weaponOwnerPos;
    public GameObject projectile;
    protected Vector2 shootingDirection;
    public float projectileForce = 0.1f;

    private void Start()
    {
        weaponOwnerTransform = GetComponentInParent<Transform>().parent;
    }
    protected Vector2 ShootingDirectionCalculating()
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

    protected virtual void Shoot()
    {

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
            Shoot();
    }
}