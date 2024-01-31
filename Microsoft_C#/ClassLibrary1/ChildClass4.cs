using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ChildClass4 : IEmployee2, IEmployee3
    {
        public ChildClass4()
        {
            
        }

        //public void Move()
        //{
        //    Console.WriteLine();
        //}

        // explicit interface implementation 
        void IEmployee3.Move() { Console.WriteLine(); }
        void IEmployee2.Move() { Console.WriteLine(); }

        //public void Add(int a, int b)
        //{
        //    Console.WriteLine($"From childclass4 - {a + b}");
    }
}
