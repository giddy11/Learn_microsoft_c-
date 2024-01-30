namespace ClassLibrary1
{
    public class Employee
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

        public virtual string GetHealthInsuranceAmount(int add)
        {
            return "Health Insurance amount is:" + 500 + add;
        }

        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }


    }
}
