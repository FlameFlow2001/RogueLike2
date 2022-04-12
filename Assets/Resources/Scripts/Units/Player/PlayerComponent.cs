using UnityEngine;

public class PlayerComponent : UnitComponent
{
    [HideInInspector] public PlayerMovement playerMovement;
    [HideInInspector] public PlayerSlot playerSlot;
    [HideInInspector] public Rigidbody2D rb;

    public override void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        unitStats = gameObject.GetComponent<UnitStats>();
        playerMovement = gameObject.GetComponent<PlayerMovement>();
        playerSlot = gameObject.GetComponent<PlayerSlot>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
}
