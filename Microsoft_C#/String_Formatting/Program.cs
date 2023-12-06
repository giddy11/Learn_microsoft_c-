int[] quarters = { 1, 2, 3, 4 };
int[] sales = { 100000, 150000, 200000, 225000 };
double[] int1MixPct = { .386, .413, .421, .457 };
string str1 = "TestStr";
int val1 = 1234;
decimal val2 = 1234.5678m;

// Basic Formatting information
Console.WriteLine("{0}", str1);
Console.WriteLine($"{str1}");

// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point),
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)
//Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", val1);
Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G}"); // 1234, 1,234.00, 1234.00, 1234
Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G}"); // 1.234568E+003, 1,234.57, 1234.57, 1234.5678



// TODO: Add a number after the format to specify precision
Console.WriteLine($"{val1:D6}, {val1:N2}, {val1:F1}, {val1:G3}"); // 001234, 1,234.00, 1234.0, 1.23E+03
Console.WriteLine($"{val2:E6}, {val2:N2}, {val2:F1}, {val2:G3}"); // 1.234568E+003, 1,234.57, 1234.6, 1.23E+03


// TODO: Formatting with alignment and spacing
//Console.WriteLine("{0,12} {0,12} {0,12} {0,12}" val1);
Console.WriteLine($"{quarters[0],12} {quarters[1],12} {quarters[2],12} {quarters[3],12}"); //                    1            2            3            4
Console.WriteLine($"{sales[0],12:C0} {sales[1],12:C0} {sales[2],12:C0} {sales[3],12:C0}"); //     $100,000     $150,000     $200,000     $225,000
Console.WriteLine($"{int1MixPct[0],12:P0} {int1MixPct[1],12:P0} {int1MixPct[2],12:P0} {int1MixPct[3],12:P0}"); //          39%          41%          42%          46%









