
Pair<int, string> myPair = new Pair<int, string>(42, "Hello");

Console.WriteLine(myPair.ToString());





int a = 9;
int b = 7;
T AddNumbers<T>(T num1, T num2) where T : struct
{
    return (dynamic)num1 + (dynamic)num2;
}

int sum = AddNumbers<int>(a, b);

//Console.WriteLine(sum);

public class Pair<T1, T2>
{
    public T1 First { get; set; }
    public T2 Second { get; set; }

    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }

    public override string ToString()
    {
        return $"{First}, {Second}";
    }
}
