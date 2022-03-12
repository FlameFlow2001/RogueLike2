using UnityEngine;

public class WeaponPickup : PickableObjects
{
    [SerializeField] private GameObject weaponPref;
    [SerializeField] private Transform weaponSlot;
    private void Start()
    {
        
    }

    protected override void PickingUpEffect()
    {
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