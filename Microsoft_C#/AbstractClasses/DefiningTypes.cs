namespace AbstractClasses
{
    internal class DefiningTypes
    {
    }

    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public abstract class Employee : IPerson
    {
        //IPerson
        public string LastName { get; set; }
        public string FirstName { get; set; }


        public DateOnly StartDate { get; set; }

        //virtual property
        public virtual DateTime EndDate { get; set; }

        //abstract property
        public abstract int EmployeeId { get; }

        //derived must implement
        public abstract bool ProcessPayroll();

        //derived can implement
        public virtual void Terminate(DateTime terminationEffectiveDate)
        {
            Console.WriteLine("Employee terminated");
            EndDate = terminationEffectiveDate;
        }

        //derived can call or hide
        public bool IsActive()
        {
            Console.WriteLine("Employee Active");
            DateOnly current = DateOnly.FromDateTime(DateTime.Now);
            return current > StartDate && DateTime.Now < EndDate;
        }
    }

    //[Flags]
    public enum ShiftDays
    {
        Sunday = 1,       // 00000001 in binary
        Monday = 2,       // 00000010 in binary
        Tuesday = 4,      // 00000100 in binary
        Wednesday = 8,    // 00001000 in binary
        Thursday = 16,    // 00010000 in binary
        Friday = 32,      // 00100000 in binary
        Weekdays = 63,    // 00111111 (combination of all weekday flags)
        Saturday = 64,    // 01000000 in binary
        Weekend = 65      // 01000001 (combination of Saturday and Sunday)
    }


    public class ShiftWorker : Employee
    {
        public ShiftDays DaysAvailable { get; set; }
        public TimeOnly ShiftStartTime { get; set; }
        public override int EmployeeId { get => 1; }

        public override bool ProcessPayroll()
        {
            Console.WriteLine("Shiftworker payroll");
            return true;
        }
        public new bool IsActive()
        {
            Console.WriteLine("Shiftworker active");
            return false;
        }
    }
    public class Manager : Employee
    {
        public int NumberOfDirectReports { get; set; }
        public override int EmployeeId { get => new System.Random().Next(1, 100); }

        public override bool ProcessPayroll()
        {
            Console.WriteLine("Manager payroll");
            return true;
        }

        public new void Terminate(DateTime terminationEffectiveDate)
        {
            //perform manager specific termination steps
            Console.WriteLine("Manager terminated");

            //optional - call base implementation
            base.Terminate(terminationEffectiveDate);
        }
    }
}
