public class Coin : PickableObjects
{
    public int coinValue;
    protected override void PickingUpEffect()
    {
        playerStats.AddCoins(coinValue);
    }
}
