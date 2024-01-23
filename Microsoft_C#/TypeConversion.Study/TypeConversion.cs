

namespace TypeConversion.Study
{
    public class TypeConversion
    {

        public static void MainMethod()
        {
            int a = 90;

            byte b;

            b = (byte)a;

            System.Convert.ToByte(b);
            Convert.ToDouble(b);
            Console.WriteLine(b);
        }
    }
}
