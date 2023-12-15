namespace ComsoleApp1.CollectionSample
{
    public class Arrays1
    {
        public Arrays1()
        {
        }
        public static void ArrayValue()
        {
            array = new int[] { 1, 2, 3, 4, 5 };
            int[] arrayCopy = new int[6];
            arrayString = new string[] { "hello", "good", "buy", "hallelu" };
            //Array.Copy(array, arrayCopy, array.Length);
            //array.CopyTo(arrayCopy, 2);
            var arrClone = (int[])array.Clone();
            //var arrClone = array.Clone() as int[];
            //int search = Array.IndexOf(array, 4);
            //int binSearch = Array.BinarySearch(array, 3);
            //Array.Resize(ref array, 8);
            //array[5] = 4;
            //Array.Clear(arrayString, 1, 3);
            //Array.Clear(array);
            //Console.WriteLine(array.ToString());
            //Console.WriteLine($"Searched at index{search}");
            //Console.WriteLine($"Searched at index{search}");
            //Console.WriteLine($"Element 2 - {array[2]}");
            //Console.WriteLine($"{array[5]}");


            foreach (int i in arrClone)
            {
                Console.Write($"{i} ");
            }

        }

        public static void MultiArray()
        {
            // multi-dim array 2*3
            int[,] a = new int[4, 3]
            {
                { 10, 20, 30 },
                { 1, 2, 4 },
                { 5, 6, 8 },
                { 7, 9, 10 }
            };

            //read data from multi-dim array
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


        }

        public static void JaggedArray()
        {
            // Jagged-dim array 2*3
            int[][] a = new int[4][];
            a[0] = new int[3] { 1, 3, 5 };
            a[1] = new int[1] { 1 };
            a[2] = new int[4] { 1, 3, 5, 8 };
            a[3] = new int[2] { 1, 3 };


            //read data from multi-dim array
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


        }

        public static void ArraysOfObjects()
        {
            // one way
            //Employee emp1 = new Employee(1, "gideon");
            //Employee emp2 = new Employee(2, "daniel");
            //Employee emp3 = new Employee(3, "caro");

            //Employee[] empData = new Employee[] { emp1, emp2, emp3 };

            //Second way
            Employee[] employees = new Employee[]
            {
                new Employee(1, "gideon"),
                new Employee(2, "daniel"),
                new Employee(3, "caro")
            };


            // Shallow copy
            var empClone = employees.Clone() as Employee[];
            empClone[0].Name = "Azi";


            // Deep copy
            var empDeepCopy = new Employee[employees.Length];

            for (int i = 0; i < employees.Length; i++)
            {
                var res = (Employee)employees[i].Clone();
                empDeepCopy[i] = res;
            }

            empDeepCopy[0].Name = "Changed";


            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.EmpId} - {emp.Name}");
            }

            Console.WriteLine();
        }





        //public override string ToString()
        //{
        //    return $"{array}";
        //}

        private static int[] array;
        private static string[] arrayString;

    }
}
