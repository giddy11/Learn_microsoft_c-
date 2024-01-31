namespace ClassLibrary3
{
    public class Book : ILoanable, IPrintable
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int LoanPeriod { get; set; }
        public string Borrower { get; set; }

        public void Borrow()
        {
            Console.WriteLine($"{Borrower} just borrowed the book {Title}");
        }

        public void Print()
        {
            Console.WriteLine($"Author:{Author}\nTitle:{Title}\nISBN:{ISBN}\nLoanPeriod:{LoanPeriod}");
        }

        public void Return()
        {
            Console.WriteLine($"{Borrower} just returned the book {Title}");
        }
    }
}
