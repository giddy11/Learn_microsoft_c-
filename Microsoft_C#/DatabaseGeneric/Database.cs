using System.Collections;

namespace DatabaseGeneric
{
    public class Database<TKey, TValue>
    {
        public Database()
        {
            keys = new TKey[10];
            values = new TValue[10];
            Count = 0;
        }

        public void ResizeArray()
        {
            int capacity = keys.Length * 2;
            Array.Resize(ref keys, capacity);
            Array.Resize(ref values, capacity);
        }

        public void ReduceArray()
        {
            int capacity = keys.Length / 2;
            Array.Resize(ref keys, capacity);
            Array.Resize(ref values, capacity);
        }

        public string Add(TKey key, TValue value)
        {
            string info = "";
            if (Count == keys.Length)
            {
                ResizeArray();
            }
            keys[Count] = key;
            values[Count] = value;
            info = "A pair of key/value has been added to the database.";
            Count++;

            return info;
        }

        public bool Remove(TKey key)
        {
            int index = Array.IndexOf(keys, key);
            if (index != -1)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    keys[i] = keys[i + 1];
                    values[i] = values[i + 1];
                }

                Count--;

                if (Count < keys.Length / 4)
                {
                    ReduceArray();
                }

                return true;
            }
            return false;
        }

        

        public static void MainMethod()
        {
            var database = new Database<int, string>();

            string add1 = database.Add(1, "One");
            string add2 = database.Add(2, "Two");
            string add3 = database.Add(3, "Three");
            string add4 = database.Add(4, "Four");
            string add5 = database.Add(5, "Five");
            string add6 = database.Add(6, "Six");
            string add7 = database.Add(7, "Seven");
            string add8 = database.Add(8, "Eight");
            string add9 = database.Add(9, "Nine");
            string add10 = database.Add(10, "Ten");

            //Console.WriteLine(add1);
            //Console.WriteLine(add2);
            //Console.WriteLine(add3);
            //Console.WriteLine(add4);
            //Console.WriteLine(add5);
            //Console.WriteLine(add6);
            //Console.WriteLine(add7);
            //Console.WriteLine(add8);
            //Console.WriteLine(add9);
            //Console.WriteLine(add10);

            int num = database.Count;
            Console.WriteLine($"Before remove:\nCount: {num}");

            //Console.WriteLine($"Value for key {database.keys}: {database.values}");
            Console.WriteLine($"Value for key 4: Four");

            database.Remove(4);
            database.Remove(1);
            database.Remove(6);
            database.Remove(3);
            database.Remove(9);
            database.Remove(2);
            database.Remove(5);
            database.Remove(7);
            database.Remove(8);
            database.Remove(10);
            database.Remove(10);

            database.Add(1, "One");
            database.Add(2, "Two");
            database.Add(3, "Three");
            database.Add(4, "Four");


        }



        private TKey[] keys;
        private TValue[] values;
        public int Count { get; private set; }
    }
}
