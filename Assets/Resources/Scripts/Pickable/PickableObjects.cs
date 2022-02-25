using UnityEngine;

public class PickableObjects : MonoBehaviour
{
    protected GameObject player;
    virtual protected void PickingUp() { }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player = other.gameObject;
            PickingUp();
            Destroy(gameObject);
        }
    }
}