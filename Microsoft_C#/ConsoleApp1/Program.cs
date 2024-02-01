// See https://aka.ms/new-console-template for more information
using Library.Structures;

Console.WriteLine("Hello, World!");

Category category = new Category() { CategoryID = 20, CategoryName = "General"};
int len = category.GetCategoryNameLength();

Console.WriteLine(len);