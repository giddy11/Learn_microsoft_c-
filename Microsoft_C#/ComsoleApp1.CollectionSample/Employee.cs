namespace ComsoleApp1.CollectionSample
{
    public class Employee : ICloneable
    {
        public Employee()
        {

        }
        public Employee(int empId, string name)
        {
            EmpId = empId;
            Name = name;
        }

        public object Clone()
        {
            var emp = new Employee() { EmpId = this.EmpId, Name = this.Name };

            return emp;
        }



        public int EmpId { get; set; }
        public string Name { get; set; }
    }
}
