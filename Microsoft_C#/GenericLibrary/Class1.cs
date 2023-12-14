namespace GenericLibrary
{
    public class Class1
    {
    }

    public class Employee
    {
        public int Salary { get; set; }
    }

    public class Student
    {
        public int Marks { get; set; }
    }

    //a class with generic method
    public class Sample
    {
        public void PrintData<T>(T obj) where T : class
        {
            if (obj.GetType() == typeof(Student))
            {
                var temp = obj as Student;
                Console.WriteLine(temp.Marks);
            }
            else if (obj.GetType() == typeof(Employee))
            {
                var temp = obj as Employee;
                Console.WriteLine(temp.Salary);
            }
        }
    }
}
