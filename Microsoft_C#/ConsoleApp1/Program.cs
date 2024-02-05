// See https://aka.ms/new-console-template for more information
using Library.Structures;

Console.WriteLine("Hello, World!");

//Shallow copy example
Point originalPoint = new Point { X = 1, Y = 2 };
Point shallowCopy = originalPoint;
shallowCopy.X = 10;
Console.WriteLine(originalPoint.X); // output = 1

//Deep copy example
Point deepCopy = new Point { X = originalPoint.X, Y = originalPoint.Y };
deepCopy.X = 10;
Console.WriteLine(originalPoint.X); // output = 1



Console.WriteLine();