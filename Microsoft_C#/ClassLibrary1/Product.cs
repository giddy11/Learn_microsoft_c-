namespace ClassLibrary1
{
    public class Product
    {
        public Product()
        {
            DateOfPurchase = DateTime.Now.ToShortDateString();
            TotalNoProducts++;

        }
        public Product(int id, string productName, double cost, int quantityInStock)
        {
            Id = id;
            ProductName = productName;
            Cost = cost;
            QuantityInStock = quantityInStock;
        }

        public static void MainMethod()
        {
            var product1 = new Product()
            {
                Id = 1001,
                ProductName = "Mobile",
                Cost = 20000,
                QuantityInStock = 1200
            };
            //Product.TotalNoProducts++;

            Console.WriteLine(product1.DateOfPurchase);

            var product2 = new Product()
            {
                Id = 1002,
                ProductName = "Laptop",
                Cost = 45000,
                QuantityInStock = 3400
            };
            Console.WriteLine(product1.DateOfPurchase);

            //Product.TotalNoProducts++;

            var product3 = new Product()
            {
                Id = 1003,
                ProductName = "Speakers",
                Cost = 36000,
                QuantityInStock = 800
            };
            Console.WriteLine(product1.DateOfPurchase);

            //Product.TotalNoProducts++;

        }

        private int Id;
        public string ProductName;
        public double Cost;
        public int QuantityInStock;
        public static int TotalNoProducts;
        public readonly string DateOfPurchase;
    }
}
