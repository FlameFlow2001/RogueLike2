using UnityEngine;

public class UnitComponent : MonoBehaviour
{
    [HideInInspector] public Animator animator;
    [HideInInspector] public UnitStats unitStats;
    [HideInInspector] public UnitUI unitUI;

    public virtual void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        unitStats = gameObject.GetComponent<UnitStats>();
        unitUI = gameObject.GetComponent<UnitUI>();
    }
}
