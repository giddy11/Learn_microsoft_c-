// TODO: Create new object instances using the "new" operator
/*
Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);

// TODO: Call a method on the object
Console.WriteLine(b1.GetDescription());
Console.WriteLine(b2.GetDescription());


// TODO: try to set one of the properties --
// this will result in an error
b1._name = "changed";
Console.WriteLine(b1.GetDescription());

*/

/*
Book1 b1 = new Book1("War and Peace", "Leo Tolstoy", 825);

// In previous example, this would fail, but will now work since
// the field name is declared as public
//b1._name = "Cat in the Hat";
Console.WriteLine(b1.GetDescription());


// TODO: set data using functions instead of accessing fields directly
b1.SetName("dog");
b1.SetAuthor("Anthony");
b1.SetPageCOunt(3);
Console.WriteLine(b1.GetDescription());
*/

/*
Book2 b1 = new Book2("War and Peace", "Leo Tolstoy", 825);

// Access a couple of properties
Console.WriteLine(b1.Name);
Console.WriteLine(b1.Description);

// Set the ISBN and Price properties
b1.ISBN = "100140447938";
b1.Price = 24.95m;
Console.WriteLine(b1.ISBN);
Console.WriteLine(b1.Price);

// Change the Name and PageCount
b1.Name = "Crime and Punishment";
b1.PageCount = 652;
Console.WriteLine(b1.Description);
Console.WriteLine(b1.Name);
Console.WriteLine(b1.PageCount);

*/

/*
// create some publications
Book3 b1 = new Book3("War and Peace", "Leo Tolstoy", 825, 39.95m);
var m1 = new Magazine("Time", "Time USA, LLC", 75, 4.95m);

Console.WriteLine($"{b1.Name}, {b1.Author}");
Console.WriteLine($"{m1.Name}, {m1.Publisher}");

// Property validation logic will prevent an empty name
//b1.Name = "";

// Call the override functions
Console.WriteLine(b1.GetDescription());
Console.WriteLine(b1.Price);
Console.WriteLine(m1.GetDescription());
Console.WriteLine(m1.Price);

*/

// TODO: Every class in C# inherits from the Object, which means
// that every class inherits the ToString() method
using CLasseS.StringRepresentation;

int x = 1000;
//Console.WriteLine(x.ToString());

// TODO: if you don't override the method, the default behavior just prints
// the name of the class and the namespace
object a = new object();
//Console.WriteLine(a.ToString());


// TODO: use the ToString method on the Book class
Book4 b1 = new Book4("War and Peace", "Leo Tolstoy", 825);
//there is implicit conversion to a ToString() below
Console.WriteLine(b1);
Console.WriteLine(b1.ToString('F'));