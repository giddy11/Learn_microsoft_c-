namespace CLasseS.Inheritance
{
    internal class Publication
    {
        public Publication(int pageCount, decimal price, string name)
        {
            PageCount = pageCount;
            Price = price;
            Name = name;
        }

        // TODO: use the "virtual" keyword to indicate that a method can be
        // overridden by subclasses to customize behavior
        public virtual string GetDescription()
        {
            return $"Name: {_name}, PageCount: {PageCount}";
        }

        // The PageCount and Price has no backing field
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        private string _name;

        public string Name
        {
            // return the name
            get { return _name; }

            // use the setter to validate the new property value
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be blank");
                }
                _name = value;
            }
        }
    }
}
