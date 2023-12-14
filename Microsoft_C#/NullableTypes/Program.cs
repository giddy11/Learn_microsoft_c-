// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

string input = null;
//string? input = "something";
int definiteInt;
int? age = null;
Nullable<int> age2 = null;

age = 5;
age ??= 12;
//definiteInt = age ?? 17;
definiteInt = age ?? 17; // if age is null, assign 17 to age


//definiteInt = age != null ? age.Value : 17;

Console.WriteLine($"Age is: {definiteInt}");

Console.WriteLine($"Age is: {definiteInt}");
Console.WriteLine(PadAndTrim(input, 20, ' '));


//static string PadAndTrim([AllowNull] string input, int length, char padChar)
//{
//    //return input?.Trim()?.PadLeft(length, padChar);
//    if (input == null)
//        return String.Empty.PadLeft(length, padChar);
//    else
//        return input.Trim().PadLeft(length, padChar);
//}

// Constant, relational, and logical patterns
static string PadAndTrim([AllowNull] string input, int length, char padChar)
{
    if (input == null)
    {
        return String.Empty.PadLeft(length, padChar);
    }
    else if (input != null && input.Length <= length)
    {
        switch (padChar)
        {
            case (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') when padChar != 'x':
                return input.Trim().PadLeft(length, padChar);
            case >= '0' and <= '9':
                return input.Trim().PadRight(length, padChar);
            default:
                Console.WriteLine("No match found for pad character");
                break;
        }
        return input.Trim().PadLeft(length, padChar);
    }
    else
    {
        throw new ArgumentException("Input is longer than requested length");
    }
}

// Property pattern
// when you want to evaluate properties of the switch target rather than the value of the target itself?
// The property pattern allows evaluation of expressions that involve properties on the target object.
var shiftDate = new DateTime(2022, 1, 2, 16, 0, 0);
Console.WriteLine($"Shift {(IsWeekendNightShift(shiftDate) ? "is" : "is not")} a weekend night");

static bool IsWeekendNightShift(DateTime shiftDate) => shiftDate switch
{
    { Hour: >= 15, DayOfWeek: DayOfWeek.Friday or DayOfWeek.Saturday } => true,
    _ => false
};

//if (age != null)
//{
//    Console.WriteLine($"Age is: {age}");
//}

//if(age.HasValue)
//{
//    Console.WriteLine($"Age is: {age.Value}");
//}


Console.WriteLine();