using DefiningGenerics;
using Essential.Learning2.Generics;


// This is how your code will be called.
// Your answer should be the largest value in the numbers array.
// You can edit this code to try different testing cases.
int[] numbers = { 7, 17, 13, 19, 5 };
//int learnerResult = Answer.FindLargest<Solver>(numbers, yourSolver);


var c = new Customer
{
    Id = 7,
    FirstName = "customer",
    LastName = "first",
    CreateDate = new DateOnly(2022, 1, 17)

};

var c2 = new Customer
{
    Id = 3,
    FirstName = "customer",
    LastName = "second",
    CreateDate = new DateOnly(2022, 1, 17)

};

// Generic Constraints
var sorter = new Sorter<Customer>();
var customers = new Customer[] { c, c2 };
sorter.Sort(customers);
foreach (var customer in customers)
{
    Console.WriteLine($"{customer.Id}: {customer.LastName}");
}





var mapper = new CustomerToPersonMapper();
var p = c.Map<Person>(mapper);
//var m = mapper.Map(c);

Console.WriteLine(p.FirstName);
