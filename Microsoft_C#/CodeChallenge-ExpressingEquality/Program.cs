using Le = CodeChallenge_ExpressingEquality;

var a = new Le.Answer { Name = "First Employee", Age = 37, HireDate = new DateTime(2009, 11, 03) };
var b = new Le.Answer { Name = "First Employee", Age = 37, HireDate = new DateTime(2009, 11, 03) };

bool learnerResult = (a == b);

Console.WriteLine();