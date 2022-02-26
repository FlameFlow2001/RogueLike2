using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : PickableObjects
{
    public int coinValue;
    protected override void PickingUp()
    {
        playerStats.AddCoins(coinValue);
    }
}
