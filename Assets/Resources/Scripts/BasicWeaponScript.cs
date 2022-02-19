using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicWeaponScript : MonoBehaviour
{
    public Transform weaponOwnerPos;
    public GameObject projectile;
    protected Vector2 shootingDirection;
    public float projectileForce = 0.1f;

    public Vector2 ShootingDirectionCalculating()
    {
        if (weaponOwnerPos != null)
        {
            Vector2 mousePos2D = Input.mousePosition;
            var screenToCameraDistance = Camera.main.nearClipPlane;
            var mousePosNearClipPlane = new Vector3(mousePos2D.x, mousePos2D.y, screenToCameraDistance);
            Vector2 worldPointPos = Camera.main.ScreenToWorldPoint(mousePosNearClipPlane);
            Vector2 myPos = weaponOwnerPos.transform.position;
            Vector2 calculatedShootingDirection = (worldPointPos - myPos).normalized;
            return calculatedShootingDirection;
        }
        else
            return Vector2.zero;
    }

    public virtual void Shoot()
    {

    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
            Shoot();
    }
}
