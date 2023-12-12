namespace ChallengeOne
{
    public class TradingCard : Card, ICard
    {
        public TradingCard()
        {

        }

        private decimal cardPrice;

        public decimal CardPrice
        {
            get => cardPrice;
            set => cardPrice = value; // or perform any necessary logic here
        }

        private decimal discount;

        public decimal Discount
        {
            get => discount;
            set => discount = value; // or perform any necessary logic here
        }

        public decimal GetDiscountedPrice()
        {
            return 0;
        }

        public override double GetSalePrice()
        {
            return 0;
        }
    }
}
