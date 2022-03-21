using UnityEngine;

[System.Serializable]
public class Cooldown
{
    public float cooldown;
    private float cooldownCompleteTime = 0;
    public bool IsCompleted
    {
        get { return Time.time > cooldownCompleteTime; }
    } 
    public void StartCooldown() { cooldownCompleteTime = Time.time + cooldown; }
}
