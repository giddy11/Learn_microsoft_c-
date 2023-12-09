using System.Text;

int jumpCount = 10;
string[] animals = { "goats", "cats", "pigs" };

// TODO: Create a StringBuilder
var sb = new StringBuilder("initial string", 200);

// TODO: Print some basic stats about the StringBuilder
//Console.WriteLine($"Capacity: {sb.Capacity}\nLength: {sb.Length}");

// TODO: Add some strings to the builder using Append
sb.Append(" Hello");
//Console.WriteLine($"Capacity: {sb.Capacity}\nLength: {sb.Length}\n{sb.ToString()}");


// TODO: AppendLine can append a line ending
sb.AppendLine();
sb.AppendLine();
sb.AppendLine();
sb.AppendLine();
sb.AppendLine();
sb.AppendLine();
sb.AppendLine();

// TODO: AppendFormat can be used to append formatted strings
sb.AppendFormat("He did this {0} times ", jumpCount);
//sb.AppendLine();
//Console.WriteLine($"Capacity: {sb.Capacity}\nLength: {sb.Length}\n{sb.ToString()}");


// TODO: AppendJoin can iterate over a set of values
sb.AppendJoin(',', animals);
//Console.WriteLine($"Capacity: {sb.Capacity}\nLength: {sb.Length}\n{sb.ToString()}");

// TODO: Insert content at any index
sb.Replace("goats", "human");
//Console.WriteLine($"Capacity: {sb.Capacity}\nLength: {sb.Length}\n{sb.ToString()}");

// TODO: Convert to a single string
sb.Insert(5, 'e');
Console.WriteLine($"Capacity: {sb.Capacity}\nLength: {sb.Length}\n{sb.ToString()}");