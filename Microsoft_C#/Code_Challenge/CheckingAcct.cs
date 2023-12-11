public class CheckingAcct : BankAccount
{
    public CheckingAcct(string firstName, string lastName, decimal balance) : base(firstName, lastName, balance)
    {
    }

    public override decimal Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Balance -= 35;
        }
        Balance -= amount;
        return Balance;
    }
}
