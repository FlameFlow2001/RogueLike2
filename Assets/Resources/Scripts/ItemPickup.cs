using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public enum pickupObjects {COIN, SMALLHPPOTION, MEDIUMHPPOTION, BIGHPPOTION, SMALLMPPOTION, MEDIUMMPPOTION, BIGMPPOTION };
    public pickupObjects currentObject;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            switch (currentObject)
            {
                case pickupObjects.COIN:
                    PlayerStats.playerStats.AddCoins(1);
                    break;

                case pickupObjects.SMALLHPPOTION:
                    PlayerStats.playerStats.HealCharacter(25);
                    break;

                case pickupObjects.MEDIUMHPPOTION:
                    PlayerStats.playerStats.HealCharacter(50);
                    break;

                case pickupObjects.BIGHPPOTION:
                    PlayerStats.playerStats.HealCharacter(100);
                    break;
            }
            Destroy(gameObject);
        }
    }
}
