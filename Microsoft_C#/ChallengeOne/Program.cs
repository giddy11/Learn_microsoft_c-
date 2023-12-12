// This is how your code will be called.

using ChallengeOne;

var tCard = new TradingCard();
var theDerivedType = tCard.GetType();
bool isCorrectBaseType = theDerivedType.BaseType == typeof(Card);

var tCard1 = new TradingCard();
tCard1.CardPrice = 5M;
tCard1.Discount = .1M;
var discountedPrice = tCard1.GetDiscountedPrice;


Console.WriteLine();