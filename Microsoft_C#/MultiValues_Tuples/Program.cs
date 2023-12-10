// A tuple is basically a lightweight data structure that lets you group multiple
// values together in one place

// TODO: Tuples are grouped values added in C# 7
(int a, int b) tup1 = (5, 10);
var tup2 = ("Some text", 10.5f);

// TODO: Tuples values are mutable
tup1.b = 20;
tup2.Item1 = "New String";
//Console.WriteLine($"{tup1}, {tup2}");


// TODO: Functions can work with tuples
(int sum,int prod)  = PlusTimes(4, 3);
Console.WriteLine($"SUM:{sum}, PROD:{prod}");
(int, int) res = PlusTimes(6, 12);
Console.WriteLine($"Sum: {res.Item1}, Prod: {res.Item2}");

// TODO: Functions can return multiple values using tuples
static (int, int) PlusTimes(int a, int b)
{
    return (a + b, a * b);
}