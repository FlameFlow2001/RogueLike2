using UnityEngine;
[System.Serializable]
public class Cooldown
{
    [SerializeField] private float cooldownTime;
    [System.NonSerialized] private float cooldownCompleteTime = 0;
    public bool IsCompleted
    { 
        get { return Time.time > cooldownCompleteTime; }
    } 
    public void StartCooldown() { cooldownCompleteTime = Time.time + cooldownTime; }

    public float GetCooldownLeftTime() { return cooldownCompleteTime - Time.time; }

    
}
