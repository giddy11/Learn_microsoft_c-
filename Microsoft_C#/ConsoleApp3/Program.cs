// See https://aka.ms/new-console-template for more information
using ClassLibrary3;

Console.WriteLine("Hello, World!");


var book = new Book() { Author = "author1", ISBN = "1457-5874-54gt", LoanPeriod = 21, Title = "title1", Borrower = "Gideon" };
book.Print();
book.Borrow();
book.Return();

Console.WriteLine();