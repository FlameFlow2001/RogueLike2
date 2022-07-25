using UnityEngine;

public class Dash : ActiveSkill
{
    public float dashForce;
    public Cooldown dashEffectTime;
    protected override void Update()
    {
        isEnable = cooldown.IsCompleted;
        if (!dashEffectTime.IsCompleted)
            playerComponent.rb.velocity = playerComponent.playerMovement.direction * dashForce;
        else
            playerComponent.rb.velocity = Vector2.zero;
    }
    public void UseDash()
    {
        if (isEnable)
        {
            cooldown.StartCooldown();
            dashEffectTime.StartCooldown();
        }
    }
}
