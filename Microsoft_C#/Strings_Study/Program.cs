string outstr;
string str1 = "The quick brown for jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = { "one", "two", "three", "four" };

// TODO: Length of a string
int len = str1.Length;

//Console.WriteLine(len);

// TODO: Access individual characters
char ch = str1[0];
//Console.WriteLine(ch);

// TODO: iterate over a string like any other sequence of values
//foreach (char cha in str1)
//{
//    Console.Write(cha);
//}
Console.WriteLine();

// TODO: String Concatenation
//outstr = str1 + " " + str2;
outstr = string.Concat(strs);
//Console.WriteLine(outstr);

// TODO: Joining strings together with Join
outstr = string.Join(" ", strs);
//Console.WriteLine(outstr);

// TODO: String Comparison
// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
int result = String.Compare(str2, str3);
//Console.WriteLine(result);

// TODO: Equals just returns a regular Boolean
bool isEqual = str2.Equals(str1);
//Console.WriteLine(isEqual);

// TODO: String Searching
Console.WriteLine(str1.IndexOf('a'));
Console.WriteLine(str1.IndexOf("our"));
Console.WriteLine(str1.LastIndexOf('o'));
Console.WriteLine(str1.IndexOf("the"));

// TODO: String Replace
outstr = str1.Replace("the", "goat");
Console.WriteLine(outstr);
















//int x = 1006;
//int y = 0;
//int res;

//try
//{
//    if (x > 1000)
//    {
//        throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
//    }
//    res = x / y;
//    Console.WriteLine("The result is: {0}", res);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Error {ex}");
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine($"Sorry, 1000 is the limit... {ex}");
//}
//finally
//{
//    Console.WriteLine("This will always run");

//}