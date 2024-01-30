namespace ClassLibrary1
{
    public abstract class Employee
    {
        public Employee(int empId, string empName, string location)
        {
            EmpId = empId;
            EmpName = empName;
            Location = location;
        }

        // method hiding
        public string GetHealthInsuranceAmount()
        {
            return "Health Insurance amount is:" + 500;
        }

        public abstract string GetHealthInsuranceAmount(int add);

        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }


    }
}
