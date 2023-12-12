namespace ChallengeOne
{
    public abstract class Card
    {
        public abstract double GetSalePrice();

        public void UpdateInventory()
        {
            // this method has an implementation
            // the derived class doesn't need to change it
            // However, it can override if
            // marked as overridable(virtual)
        }
    }
}
