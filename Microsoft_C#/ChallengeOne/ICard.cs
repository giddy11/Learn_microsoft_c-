namespace ChallengeOne
{
    public interface ICard
    {
        public decimal CardPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal GetDiscountedPrice();
    }
}
