namespace CLasseS.Inheritance
{
    internal class Magazine : Publication
    {
        public Magazine(string publisher, string name, int pageCount, decimal price) : base(pageCount, price, name)
        {
            _publisher = publisher;
        }

        public string Publisher
        {
            get => _publisher;
            set => _publisher = value;
        }

        private string _publisher;
    }
}
