namespace CLasseS.Properties
{
    internal class Book2
    {
        // classes have one or more constructors
        public Book2(string name, string author, int pageCount)
        {
            _name = name;
            _author = author;
            _pageCount = pageCount;
        }

        public string GetDescription()
        {
            return $"{_name} by {_author}, {_pageCount} pages";
        }

        // TODO: Member variables can be accessed via methods
        public string GetName()
        {
            return _name;
        }

        public void SetName(string s)
        {
            _name = s;
        }

        public void SetAuthor(string s)
        {
            _author = s;
        }

        public void SetPageCOunt(int c)
        {
            _pageCount = c;
        }

        // classes have instance variables to hold data
        private string _name;
        private string _author;
        private int _pageCount;

        // TODO: use properties to implement access to our internal data
        // This is called a Property with a "backing field"
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // TODO: There's a shorthand way of writing these using the => operator
        // to create "expression-bodied" properties
        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int PageCount
        {
            get => _pageCount;
            set => _pageCount = value;
        }

        // TODO: You can omit the get or set if you want to prevent
        // modification or reading the value, or if you want to create
        // a "computed property" from other fields
        public string Description
        {
            get => $"{Name} by {Author}, {PageCount} pages";
        }

        // TODO: Properties can be auto-generated - if there's no
        // backing field, the property can hold the data
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
}
