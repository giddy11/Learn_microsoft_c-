namespace ClassLibrary3
{
    public class CD : ILoanable, IPrintable
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int NumberOfTracks { get; set; }
        public int LoanPeriod { get; set; }
        public string Borrower { get; set; }

        public void Borrow()
        {
            Console.WriteLine($"{Borrower} just borrowed the CD {Title}");
        }

        public void Print()
        {
            Console.WriteLine($"Artist:{Artist}\nTitle:{Title}\nNumberOfTracks:{NumberOfTracks}\nLoanPeriod:{LoanPeriod}");
        }

        public void Return()
        {
            Console.WriteLine($"{Borrower} just returned the CD {Title}");
        }
    }
}
