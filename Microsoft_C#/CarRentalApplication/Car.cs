using System.Runtime.CompilerServices;

namespace CarRentalApplication
{
    public class Car
    {
        public Car(string make, string model, decimal price, bool isAvailable = true)
        {
            _make = make;
            _model = model;
            _price = price;
            _isAvailable = isAvailable;
            Id = idUpdate++;
        }

        public Car()
        {
        }

        public string PrintInformation()
        {
            string info = "";
            foreach (var car in _cars)
            {
                string isAvailable = car._isAvailable ? "Available" : "Rented";
                info += $"{car.Id}. {car._make} {car._model} (Rental price: {car._price}/day) - {isAvailable}\n";
            }

            return info;
        }

        public static void AddMultipleCars(List<Car> carsToAdd)
        {
            _cars.AddRange(carsToAdd);
        }

        public static void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public (bool, string) RentingCar(int id)
        {
            Car? carId = _cars.Find(x => x.Id == id);
            if (carId == null)
            {
                return (false, "Sorry, the selected car is not available for rent.\n");
            }
            if (carId._isAvailable == true)
            {
                carId._isAvailable = false;
                return (true, $"Rented the {carId._model} {carId._make} for ${carId._price}/day.\n");
            }
            else
            {
                return (false, $"Sorry, the {carId._model} {carId._make} is not available for rent.\n");
            }
        }

        public string ReturningCar(int id)
        {
            Car? carId = _cars.Find(x => x.Id == id);
            if (carId == null)
            {
                return $"No Car with {carId.Id} exist.\n";
            }
            if (carId._isAvailable == false)
            {
                carId._isAvailable = true;
                return $"Returned the {carId._make} {carId._model}.\n";
            }
            else
            {
                return $"{carId._make} {carId._model} hasn't been rented.\n";
            }
        }

        public static void MainMethod()
        {
            List<Car> newCars = new List<Car>()
            {
                new Car("Toyota","Corolla", 50, true),
                new Car("Honda","Civic", 60, true),
                new Car("Ford","Mustang", 80, true)
            };

            Car car = new Car();

            bool isOn = true;

            AddMultipleCars(newCars);

            Console.WriteLine("Welcome to the car rental system!");

            while(isOn)
            {
                Console.WriteLine("Menu:\n1. Rent a car\n2. Return a car\n3. View available cars\n4. Exit\n");
                Console.Write("Please enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("\nRent a Car: ");
                    Console.WriteLine(car.PrintInformation());
                    Console.Write("Please enter the ID of the car you want to rent: ");
                    int choiceId = int.Parse(Console.ReadLine());
                    (bool result, string message) = car.RentingCar(choiceId);
                    //car.RentingCar(choiceId);
                    Console.WriteLine(message);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nReturn a Car: ");
                    Console.WriteLine(car.PrintInformation());
                    Console.Write("Please enter the ID of the car you want to return: ");
                    int choiceId = int.Parse(Console.ReadLine());
                    string message = car.ReturningCar(choiceId);
                    //car.RentingCar(choiceId);
                    Console.WriteLine(message);
                }
                else if (choice == 3)
                {
                    Console.WriteLine($"Available cars:\n{car.PrintInformation()}");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thank you for using the car rental system!");
                    isOn = false;
                }
            }
        }


        public int Id { get; private set; }
        private static int idUpdate = 1;
        private string _make { get; set; }
        private string _model { get; set; }
        private decimal _price { get; set; }
        private bool _isAvailable { get; set; } = false;
        private static List<Car> _cars = new List<Car>();
    }
}
