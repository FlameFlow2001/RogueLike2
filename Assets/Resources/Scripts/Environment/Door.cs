using UnityEngine;

public class Door : TriggeredObjects
{
    public Sprite openedDoorSprite;
    public Sprite closedDoorSprite;

    override protected void TriggerEffect(GameObject triggerer)
    {
        if (triggerer.tag == "Player" || triggerer.tag == "Enemy")
        {
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
