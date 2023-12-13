// See https://aka.ms/new-console-template for more information


//Employee sw = new ShiftWorker
using AbstractClasses;

ShiftWorker sw = new ShiftWorker
{
    FirstName = "staff",
    LastName = "one",
    StartDate = new DateOnly(2014, 2, 17),
    ShiftStartTime = new TimeOnly(8, 30)
};


Console.WriteLine("=============Shift Worker=============");
bool payrollProcessed = sw.ProcessPayroll();
sw.Terminate(DateTime.Now);
bool active = sw.IsActive();
Console.WriteLine();

//Manager mgr = new Manager
Employee mgr = new Manager
{
    FirstName = "manager",
    LastName = "one",
    NumberOfDirectReports = 7
};

Console.WriteLine("=============Manager=============");
bool mgrPayrollProcessed = mgr.ProcessPayroll();
mgr.Terminate(DateTime.Now);
bool mgrActive = mgr.IsActive();

// Dynamic variables do not undergo compile time checking of member access
// enabling them to be used to reference any object. At runtime, errors will
// occur if the members accessed are not present on the object referenced.
dynamic test = new ShiftWorker() { FirstName = "Gideon" };
test.FirstName = "Timothy";
Console.WriteLine(test.FirstName);

#region Enums Testing

ShiftWorker d = new ShiftWorker()
{
    FirstName = "Dynamic",
    LastName = "Worker"
};
d.DaysAvailable = ShiftDays.Weekend;// | ShiftDays.Weekend;
bool availableMonday = d.DaysAvailable.HasFlag(ShiftDays.Monday);
Console.WriteLine($"Available Mondays {availableMonday}");

bool availableSaturdays = (d.DaysAvailable & ShiftDays.Saturday) == ShiftDays.Saturday;
Console.WriteLine($"Available Saturdays {availableSaturdays}");

Console.WriteLine(d.DaysAvailable);

var shiftNames = Enum.GetNames(typeof(ShiftDays));
Console.WriteLine(String.Join(',', shiftNames));

var shiftValues = (short[])Enum.GetValues(typeof(ShiftDays));
Console.WriteLine(String.Join(',', shiftValues));




Console.WriteLine(d.DaysAvailable);

var day = DayOfWeek.Monday;
//Console.WriteLine(day);
var shiftDay = ShiftDays.Tuesday;
//Console.WriteLine((int)shiftDay);


#endregion

Console.WriteLine();