using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : PickableObjects
{
    public GameObject weaponPref;
    private Transform weaponSlot;

    protected override void PickingUp()
    {
        weaponSlot = player.transform.Find("Weapon");
        if (weaponSlot)
        {
            for (int i = 0; i < weaponSlot.childCount; i++)
            {
                Destroy(weaponSlot.GetChild(i).gameObject);
            }
        }
        var weapon = Instantiate(weaponPref);
        weapon.transform.SetParent(weaponSlot);
    }
}