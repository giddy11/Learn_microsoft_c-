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
        public Product(string productName, double cost, int quantityInStock)
        {
            ProductName = productName;
            Cost = cost;
            QuantityInStock = quantityInStock;
        }

        public static void MainMethod()
        {
            var product1 = new Product()
            {
                ProductName = "Mobile",
                Cost = 20000,
                QuantityInStock = 1200
            };
            double tax1 = product1.CalculateTax();
            product1.CalculateTax1();
            product1.SetProductID(1001);
            int getId = product1.GetProductID();
            int val = product1.NamedArgument(res2: 3, res1: 2);


            var product2 = new Product()
            {
                Id = 1002,
                ProductName = "Laptop",
                Cost = 45000,
                QuantityInStock = 3400
            };
            double tax2 = product2.CalculateTax();
            product2.CalculateTax1();
            int getId2 = product2.GetProductID();


            var product3 = new Product()
            {
                Id = 1003,
                ProductName = "Speakers",
                Cost = 36000,
                QuantityInStock = 800
            };
            double tax3 = product3.CalculateTax();
            product3.CalculateTax1();
            int getId3 = product3.GetProductID();

            int totalQty = Product.GetTotalQuantity(product1, product2, product3);

        }

        public double CalculateTax()
        {
            double tax = 0;
            if (Cost <= 20000)
            {
                tax = Cost * 0.1;
                return tax;
            }
            return Cost * 0.125;
        }

        public void CalculateTax1()
        {
            double t = 0;
            if (Cost <= 20000)
            {
                t = Cost * 0.1;
            }
            else
                t = Cost * 0.125;

            tax = t;
        }

        //Set method for ProductID
        public void SetProductID(int productID)
        {
            this.Id = productID;
        }

        public int GetProductID()
        {
            return Id;
        }

        public static int GetTotalQuantity(Product product1, Product product2, Product product3)
        {
            return product1.QuantityInStock + product2.QuantityInStock + product3.QuantityInStock;
        }

        public int NamedArgument(int res1, int res2)
        {
            return res1 + res2;
        }



        private int Id;
        private string ProductName;
        private double Cost;
        private int QuantityInStock;
        public static int TotalNoProducts;
        private readonly string DateOfPurchase;
        private double tax;
    }
}
