﻿namespace DelegateExample
{
    public class Class2
    {
        public void Add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine($"Addition is:{c}");
        }

        public void Multiply(double a, double b)
        {
            double c = a * b;
            Console.WriteLine($"Multiplication is:{c}");
        }
    }
}
