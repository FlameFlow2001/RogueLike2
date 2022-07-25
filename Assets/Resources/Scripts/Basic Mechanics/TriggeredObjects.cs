using UnityEngine;

public class TriggeredObjects : MonoBehaviour
{
    protected GameObject triggerer;
    private void OnTriggerEnter2D(Collider2D other)
    {
        triggerer = other.gameObject;
        TriggerEffect(triggerer);
}

    protected virtual void TriggerEffect(GameObject triggerer) { }
}
