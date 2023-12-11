namespace Code_Challenge
{
    internal class SavingsAcct : BankAccount
    {
        public SavingsAcct(string firstName, string lastName, decimal interestRate, decimal balance) : base(firstName, lastName, balance)
        {
            InterestRate = interestRate;
        }

        public decimal ApplyInterest()
        {
            decimal temp = InterestRate * Balance;
            return Balance += temp;
        }

        public override decimal Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine($"Current balance is {Balance}. Sorry you can't withdraw {amount}, please deposit.");
                return Balance;
            }
            if (_withdrawalCount > 2)
            {
                Balance -= 2;
                Console.WriteLine($"Your number of withdrawals is {_withdrawalCount} which has exceeded, charge fee of $2 applies");
                _withdrawalCount = 0;
            }
            Balance -= amount;
            _withdrawalCount++;
            return Balance;
        }

        public decimal InterestRate { get; set; }
        private int _withdrawalCount = 0;
    }
}
