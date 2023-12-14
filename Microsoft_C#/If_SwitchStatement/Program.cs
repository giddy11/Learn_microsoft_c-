using AbstractClasses;

var shiftDay = GetShiftDays((DayOfWeek)17);
Console.WriteLine(shiftDay);

// Switch statement and expression
// The switch statement is used to control execution of multiple statements
// while the switch expression is used to select an expression to evaluate to return a value.
static ShiftDays GetShiftDays(DayOfWeek day) => day switch
{
    DayOfWeek.Monday => ShiftDays.Monday,
    DayOfWeek.Tuesday => ShiftDays.Tuesday,
    DayOfWeek.Wednesday => ShiftDays.Wednesday,
    DayOfWeek.Thursday => ShiftDays.Thursday,
    DayOfWeek.Friday => ShiftDays.Friday,
    DayOfWeek.Saturday => ShiftDays.Saturday,
    DayOfWeek.Sunday => ShiftDays.Sunday,
    _ => throw new ArgumentException("Invalid day of week supplied")

};


IPerson sw = new ShiftWorker { FirstName = "Shift", LastName = "Worker", StartDate = new DateOnly(2020, 7, 15) };
IPerson mgr = new Manager { FirstName = "Manager", LastName = "Worker", NumberOfDirectReports = 7 };

Console.WriteLine(GetPersonDetails(sw));
Console.WriteLine(GetPersonDetails(mgr));

// method one
//static string GetPersonDetails(IPerson p)
//{
//    ShiftWorker? swv = p as ShiftWorker;
//    if (swv != null)
//    {
//        return $"{swv.FirstName} {swv.LastName}: {swv.StartDate}";
//    }
//    return String.Empty;
//}

// method two
//static string GetPersonDetails(IPerson p)
//{
//    //ShiftWorker? swv = p as ShiftWorker;
//    if (p is ShiftWorker swv)
//    {
//        return $"{swv.FirstName} {swv.LastName}: {swv.StartDate}";
//    }
//    else if (p is Manager mgr)
//    {
//        return $"{mgr.FirstName} {mgr.LastName} Reports: {mgr.NumberOfDirectReports}";
//    }
//    return String.Empty;
//}

/* Introduction to pattern
// What is a pattern in a switch statement/expression?
// Patterns extend the comparisons available in switch expressions or statements beyond
// simple types like char, string, or int.
*/

//static string GetPersonDetails(IPerson p)
//{
//    var result = p switch
//    {
//        ShiftWorker swv => $"{swv.FirstName} {swv.LastName}: {swv.StartDate}",
//        Manager mgr => $"{mgr.FirstName} {mgr.LastName} Reports: {mgr.NumberOfDirectReports}",
//        _ => string.Empty
//    };

//    return result;
//}

/*
 Guard Conditions
 A guard condition is applied after patterns in a switch branch to further
 constrain the expression. "when"
*/

static string GetPersonDetails(IPerson p)
{
    var result = p switch
    {
        ShiftWorker swv when swv.StartDate.Year > 2020 => $"{swv.FirstName} {swv.LastName}: {swv.StartDate}",
        ShiftWorker swv when swv.StartDate.Year <= 2020 => $"Older employee",
        Manager mgr => $"{mgr.FirstName} {mgr.LastName} Reports: {mgr.NumberOfDirectReports}",
        _ => string.Empty
    };

    return result;
}
