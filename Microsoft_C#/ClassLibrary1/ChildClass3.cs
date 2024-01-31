using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ChildClass3 : Manager, IEmployee2
    {
        public ChildClass3()
        {
        }

        public ChildClass3(int empId, string empName, string location, string departmentName) : base(empId, empName, location, departmentName)
        {
        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"From childclass3 - {a + b}");
        }

        //public override string GetHealthInsuranceAmount(int add)
        //{
        //    base.GetHealthInsuranceAmount(add);
        //    return "Additional is 1000";
        //}


    }
}
