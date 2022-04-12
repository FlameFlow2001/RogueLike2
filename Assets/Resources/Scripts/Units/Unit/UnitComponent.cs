using UnityEngine;

public class UnitComponent : MonoBehaviour
{
    [HideInInspector] public Animator animator;
    [HideInInspector] public UnitStats unitStats;
    public UnitUI unitUI;

    public virtual void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        unitStats = gameObject.GetComponent<UnitStats>();
        unitUI = gameObject.GetComponent<UnitUI>();
    }
}
