namespace ClassLibrary3
{
    public interface ILoanable
    {
        public int LoanPeriod { get; set; }
        public string Borrower { get; set;}
        void Borrow();
        void Return();
    }
}
