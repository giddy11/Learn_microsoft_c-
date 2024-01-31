namespace ClassLibrary3
{
    public class DVD : ILoanable, IPrintable
    {
        public string Director { get; set; }
        public string Title { get; set; }
        public int LengthsInMinutes { get; set; }
        public int LoanPeriod { get; set; }
        public string Borrower { get; set; }

        public void Borrow()
        {
            Console.WriteLine($"{Borrower} just borrowed the DVD {Title}");
        }

        public void Print()
        {
            Console.WriteLine($"Director:{Director}\nTitle:{Title}\nLengthsInMinutes:{LengthsInMinutes}\nLoanPeriod:{LoanPeriod}");
        }

        public void Return()
        {
            Console.WriteLine($"{Borrower} just returned the DVD {Title}");
        }
    }
}
