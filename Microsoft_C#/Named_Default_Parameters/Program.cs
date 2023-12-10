// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix="")
{
    Console.WriteLine($"{prefix} {thestr}");
}

// TODO: Test the default parameters
PrintWithPrefix("Hello There");
PrintWithPrefix("Hello There", ">: ");

// TODO: Call with named params
// Especially when theres a lot of default values and for readability sake
PrintWithPrefix(prefix: "% ", thestr: "Hello There!");