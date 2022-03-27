using UnityEngine;

public class WeaponPickup : PickableObjects
{
    [SerializeField] private GameObject weaponPref;
    protected override void PickingUpEffect()
    {
        playerSlot.weapon = weaponPref.GetComponent<BasicWeaponScript>();
    }
}