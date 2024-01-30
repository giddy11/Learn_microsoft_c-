using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ChildClass3 : Manager
    {
        public ChildClass3(int empId, string empName, string location, string departmentName) : base(empId, empName, location, departmentName)
        {
        }

        //public override string GetHealthInsuranceAmount(int add)
        //{
        //    base.GetHealthInsuranceAmount(add);
        //    return "Additional is 1000";
        //}

       
    }
}
