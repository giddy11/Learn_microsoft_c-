namespace Challenge_1
{
    public class Class1
    {

    }

    public class Product
    {
        public string Name { get; set; }
        public int ProductID { get; set; }
    }
    public class Answer
    {

        // Change these Boolean values to control whether you see 
        // the expected result and/or hints.
        public static Boolean ShowExpectedResult = false;
        public static Boolean ShowHints = false;
        private static Queue<Product> _products = new Queue<Product>();
        // Return the largest number in the 'numbers' array.
        public static void Add(Product p)
        {
            // Your code goes here.
            // Add the item to a collection
            _products.Enqueue(p);

        }

        public static Product Retrieve()
        {
            //Your code goes here to retrieve the next object
            Product p = null;
            //if ( _products.Count > 0 )
            //{
            //    return _products.Dequeue();
            //}
            if (_products.TryDequeue(out p))
            {
                return p;
            }
            return null;
        }

    }
    public class Challenge_1
    {
        public static void Main()
        {
            // This is how your code will be called.
            // Your answer should be the first product from the array.
            // You can edit the array of products to test other use cases.
            var products = new Product[5];
            //var products = new Product[] {
            //new Product{Name="Widget", ProductID = 1},
            //new Product{Name="Gizmo", ProductID = 73}
            //for (int productIndex = 0; productIndex < products.Length; productIndex++)
            //{
            //    Answer.Add(products[productIndex]);
            //}


            Product learnerResult = Answer.Retrieve();
        }
    }
}
