// See https://aka.ms/new-console-template for more information
using Linkedln.Essential;

/*
var employee = new Employee
{
    FirstName = "Matt",
    LastName = "Emmy",
    StartDate = new DateOnly(2024, 12, 12),
    EmployeeId = 1
};

Console.WriteLine($"{employee.FirstName}, {employee.EmployeeId}");

*/

/*
Employee e = new Employee("Matt", "Milner", 75)
{
    StartDate = new DateOnly(2021, 1, 15)
};

Console.WriteLine($"From {e.FirstName}  id {e.Id}, hello world");

//PremiereCustomer pcust = new PremiereCustomer (2);
PremiereCustomer pcust = new PremiereCustomer { CustomerLevel = 2 };
pcust.FirstName = "New Customer";
//pcust.CustomerLevel = 2;

Console.WriteLine($"{pcust.FirstName} has level {pcust.CustomerLevel}");

Manager m = new Manager("manager", "boss");
m.SetReports(7);

*/

// See https://aka.ms/new-console-template for more information


//Classes();
Structs();
//Records();


/*
static void Classes()
{
    Console.WriteLine("=========== Classes = reference types ===========");
    //Create an employee
    Employee me = new Employee
    {
        FirstName = "Gideon",
        LastName = "Edoghotu",
        Age = new Age { BirthDate = new DateTime(1993, 1, 11), YearsOld = 30 },
        Id = 1
    };

    //create another reference to the employee
    IPerson other = me;
    other.FirstName = "Daniel";
    other.Age = new Age { BirthDate = new DateTime(1994, 1, 11), YearsOld = 29 };

    //examine results of the original object
    Console.WriteLine($"{me.FirstName} is {me.Age.YearsOld} but {other.FirstName} is {other.Age.YearsOld}");
    Console.WriteLine();

    //ChangeName(ref other);
    ChangeName(other);
    Console.WriteLine($"{other.FirstName} {other.LastName} is still {other.Age.YearsOld}");

    Console.WriteLine();
}

//static void ChangeName(ref IPerson person)
static void ChangeName(IPerson person)
{
    person.LastName = "Azibaobuom";
    person.FirstName = "Henry";
    Console.WriteLine($"Person in method is {person.FirstName} {person.LastName}");

    person = new Manager("Timothy", "Azibanigha")
    {
        Id = 2,
        Age =
        new Age { BirthDate = new DateTime(1995, 12, 11), YearsOld = 27 }
    };

    Console.WriteLine($"Person after reference change in method is {person.FirstName}");
}
*/

static void Structs()
{
    Console.WriteLine("=========== Structs = value types ===========");

    Age myAge = new Age { BirthDate = new DateTime(1971, 9, 1), YearsOld = 50 };
    Age anotherAge = myAge;

    anotherAge.YearsOld = 39;

    Console.WriteLine($"My age is {myAge.YearsOld}, but I changed it to {anotherAge.YearsOld}");

    AgeBackwords(ref anotherAge, 5);

    Console.WriteLine($"Now I am {anotherAge.YearsOld}");
    Console.WriteLine();
}

/*
static void Records()
{
    Console.WriteLine("=========== Records = reference or value types ===========");

    PremiereCustomer pc = new PremiereCustomer
    {
        FirstName = "Customer",
        LastName = "One",
        Id = 7,
        Age = new Age { BirthDate = DateTime.Now, YearsOld = 1 },
        CustomerLevel = 1
    };

    PremiereCustomer pc2 = pc with { CustomerLevel = 2, LastName = "Two" };

    Console.WriteLine($"{pc.FirstName} {pc.LastName} has a level of {pc.CustomerLevel}");
    Console.WriteLine($"{pc2.FirstName} {pc2.LastName} has a level of {pc2.CustomerLevel}");
    ChangeName((IPerson)pc);
    Console.WriteLine($"{pc.FirstName} {pc.LastName} is still {pc.Age.YearsOld}");

}
*/

static void AgeBackwords(ref Age startingAge, int numberOfYearsToAge)
{
    startingAge.YearsOld = startingAge.YearsOld - numberOfYearsToAge;
    Console.WriteLine($"Modified age in method: {startingAge.YearsOld}");
}


Console.WriteLine();
