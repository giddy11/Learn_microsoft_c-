namespace CLasseS.Modifiers
{
    // access modifiers control how properties and methods are accessed
    internal class Book1
    {
        public Book1(string name, string author, int pageCount)
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


        // TODO: "public" members and methods can be accessed by other
        // NOTE: this is *NOT* the right way to expose internal data
        string _name;

        // TODO: "protected" members can only be accessed by the class or a
        // derived class from this one
        protected string _author;

        // TODO: "private" is the default and be accessed by code within
        // the class itself
        private int _pageCount;

    }
}
