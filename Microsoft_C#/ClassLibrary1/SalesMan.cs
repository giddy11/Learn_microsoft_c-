using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SalesMan : Employee
    {
        public SalesMan(int empId, string empName, string location, string region) : base(empId, empName, location)
        {
            Region = region;
        }

        public long GetSalesfTheCurrentMonth()
        {
            return 10000;
        }

        public string Region { get; set; }
    }
}
