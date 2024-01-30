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

    public class Student
    {
        public void DisplaySubject(params string[] parameter1)
        {
            parameter1[0] = "velly";
            Console.WriteLine(parameter1[0]);
        }

        public void DisplayMarks(params int[] marks)
        {
            foreach (var mark in marks)
            {
                Console.WriteLine(mark);
            }
            double avg = CalculateAvg(marks);
            Console.WriteLine($"Average: {avg}");
        }

        private double CalculateAvg(int[] marks)
        {
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }

            return (double)(sum) / marks.Length;
        }

        public static void MainMethod()
        {
            Student s = new Student();
            //s.DisplaySubject("maths", "english");

            s.DisplayMarks(80, 45, 71);


        }
    }


    public class Employee
    {
        public Employee()
        {}

        public Employee(int empID, string empName, string job, double salary)
        {
            _empID = empID;
            _empName = empName;
            _job = job;
            _salary = 1000;
        }

        // Instance fields
        private int _empID;
        private string _empName;
        private string _job;
        private double _salary;
        private static string _companyName;

        // Instance propert
        public int EmpID
        {
            set
            {
                _empID = value;
            }
            get
            {
                return _empID;
            }
        }

        public string EmpName
        {
            set { _empName = value; }
            get { return _empName; }
        }

        public string Job
        {
            set { _job = value; }
            get { return _job; }
        }

        // readonly property
        public double Salary
        {
            get { return _salary; }
        }

        //public static string CompanyName { get => _companyName; set => _companyName = value; }
        public static string CompanyName 
        {
            set { _companyName = value; }
            get { return _companyName; }
        }

    }

    public class Car
    {
        private string[] _brands = new string[] { "BMW", "Skoda", "Honda", "Sienna" };
        private string[] _names = new string[] { "first", "second", "third", "fourth" };

        public string this[int index]
        {
            set { this._brands[index] = value; }
            get { return this._brands[index]; }
        }

        // Index Overloading
        public string this[string name]
        {
            set { this._names[Array.IndexOf(_names, name)] = value; }
            get { return this._names[Array.IndexOf(_names, name)]; }
        }
    }

    public class DebitCard
    {
        private string _pin;

        public string Pin
        {
            set
            {
                if (value.Length == 4 || value.Length == 6)
                {
                    _pin = value;
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            get
            {
                return _pin;
            }
        }
    }
}
