using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPPotion : PickableObjects
{
    public int healValue;
    protected override void PickingUp()
    {
        PlayerStats.playerStats.HealCharacter(healValue);
    }
}
