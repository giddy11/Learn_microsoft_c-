namespace CLasseS.Inheritance
{
    // TODO: Declare "Book3" as a subclass of publication
    internal class Book3 : Publication
    {
        // use the base() keyword to initialize the base class
        public Book3(string name, string author, int pageCount, decimal price) : base(pageCount, price, name)
        {
            _author = author;
        }

        // TODO: use the override keyword to override a base class method
        public override string GetDescription()
        {
            return $"{Name} by {Author}, {PageCount} pages";
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        private string _author;
        private int _pageCount;
        private decimal _price;
    }
}
