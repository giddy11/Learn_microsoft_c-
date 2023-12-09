using StringParse_Study;
using System.Globalization;

/*
string numStr1 = "1";
string numStr2 = "2.00";
string numStr3 = "3,000";
string numStr4 = "3,000.00";

//The Parse function attempts to parse a string into a number
// but it might throw an exception, so we need to catch that
int targetNum = 0;
try
{
    // TODO: Use Parse to try a simple integer
    //targetNum = int.Parse(numStr1); // 1
    //Console.WriteLine(targetNum);

    // TODO: Use Parse to try a floating point number
    // this only works if the decimal value is 0
    targetNum = int.Parse(numStr2, NumberStyles.Float); // 2
    //Console.WriteLine(targetNum);

    // TODO: Use Parse to try a number with thousands marker
    targetNum = int.Parse(numStr3, NumberStyles.AllowThousands); // 3000
    //Console.WriteLine(targetNum);


    // TODO: Use Parse to try a number with thousands marker AND decimal
    targetNum = int.Parse(numStr4, NumberStyles.AllowThousands | NumberStyles.Float); // 3000
    //Console.WriteLine(targetNum);

    // TODO: This works with other types too, like bool
    //Console.WriteLine($"{bool.Parse("True")}"); // True


    // TODO: Or floating point numbers
    //Console.WriteLine($"{float.Parse("1.237"):F2}"); // 1.24
}
catch
{
    Console.WriteLine("Conversion failed");
}

// TODO: The TryParse function is similar but handles the exceptions for us
bool succeeded = false;
succeeded = Int32.TryParse(numStr1, out targetNum);
if (succeeded)
{
    Console.WriteLine($"{targetNum}");
}

*/

// This is how your code will be called.
// You can edit this code to try different testing cases.
object[] items = { 1, 2, "Hello!", "World", 'X', true, 2.0, ".NET", 'A' };
int total = 0;
string CountType = "System.String";
foreach (object item in items)
{
    if (Answer.CountTheType(item, CountType))
    {
        total++;
    }
}