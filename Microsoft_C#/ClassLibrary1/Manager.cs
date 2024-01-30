using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Manager : Employee
    {
        public Manager(int empId, string empName, string location, string departmentName) : base(empId, empName, location)
        {
            DepartmentName = departmentName;
        }

        // method
        public long GetTotalSalesOfTheYear()
        {
            return 10000;
        }

        public string GetFullDepartmentName()
        {
            return DepartmentName + " at " + base.Location;
        }

        // method hiding
        public new string GetHealthInsuranceAmount()
        {
            return "";
        }

        public  override string GetHealthInsuranceAmount(int add)
        {
            return "Additional is 1000";
        }

        public string DepartmentName { get; set; }
    }
}
