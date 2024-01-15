namespace SortedListCollection
{
    public class Person
    {
        public static void MainMethod()
        {
            SortedList<int, string> employees = new SortedList<int, string>
            {
                {1, "Gideon" },
                {2, "Henry" },
                {4, "Suzy" },
                {3, "Sharon" }
            };


            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"{item.Key}, {item.Value}");
            //}

            string name = employees[2];
            //int val = employees.IndexOfKey(4);
            int val = employees.IndexOfValue("Sharon");


            Console.WriteLine(name);

            Console.WriteLine("The End!!!");



        }
    }


}
