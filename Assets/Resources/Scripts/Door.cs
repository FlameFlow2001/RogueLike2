using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Sprite openedDoorSprite;
    public Sprite closedDoorSprite;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Enemy")
        {
            //gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = openedDoorSprite;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Enemy")
        {
            //gameObject.GetComponent<BoxCollider2D>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = closedDoorSprite;
        }
    }
}
