
namespace ListPractice_1
{
    public class ListUse
    {






        public static void Main()
        {
            var myList = new List<List<int>>();
            var myList2 = new List<int>() {0, 1, 2, 3, 4, 5,11, 6, 3, 7, 8, 3, 9 };
            myList.Add(new List<int>() { 1, 2, 3, 4, 5, 6, 3, 7, 8, 3, 9 });
            //myList.IndexOf(myList[0]);
            //int n = myList2.IndexOf(3);
            //int n2 = myList2.IndexOf(3, n + 1);

            int[] arr3 = myList2.ToArray();

            //Console.WriteLine("list");
            //foreach (int item in myList2 )
            //{
            //    Console.WriteLine(item);
            //}
            //myList2.ForEach(myList2 => { Console.WriteLine(myList2);});

            //Console.WriteLine("arrays");
            //foreach (int item in arr3)
            //{     
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine(n);
            //Console.WriteLine(n2);

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //int n = SearchItem(arr, 11);

            var y = myList2.ConvertAll(n => Convert.ToString(n));
            //Console.WriteLine(y);

            foreach (string item in y)
            {
                Console.WriteLine(item + 1);
            }


            int SearchItem(int[] arr, int item)
            {

                int low = 0;
                int high = arr.Length - 1;
                for (; low <= high;)
                {
                    int mid = (low + high) / 2;

                    if (arr[mid] == item)
                    {
                        return mid;
                    }
                    else if (arr[mid] > item)
                    {
                        //low = mid + 1;
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                        //high = mid - 1;
                    }
                }
                return -1;
            }

            //for (int i = 0; i < myList.Count; i++)
            //{
            //    Console.WriteLine(myList[i].ToString());
            //}
        }

        
    }
}
