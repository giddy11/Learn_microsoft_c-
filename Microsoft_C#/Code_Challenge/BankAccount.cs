public class BankAccount
{
    public BankAccount(string firstName, string lastName, decimal balance)
    {
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }

    public string AccountOwner()
    {
        return $"{FirstName} {LastName}";
    }

    public decimal Deposit(decimal amount)
    {
        Balance += amount;
        return Balance;
    }

    public virtual decimal Withdraw(decimal amount)
    {
        Balance -= amount;
        return Balance;
    }

    // expression bodied properties
    public string AccountOwner1
    {
        get => $"{FirstName} {LastName}";
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Balance { get; set; } = 0.0m;
}