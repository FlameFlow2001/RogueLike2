public class HPPotion : PickableObjects
{
    public int healValue;
    protected override void PickingUpEffect()
    {
        playerStats.HealCharacter(healValue);
    }
}
