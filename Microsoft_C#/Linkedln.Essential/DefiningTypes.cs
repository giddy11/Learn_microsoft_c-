﻿namespace Linkedln.Essential
{
    internal class DefiningTypes
    {
    }

    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public Age Age { get; set; }
    }

    // classes - reference types
    public class Employee : IPerson
    {
        public Employee()
        {
            EmployeeId = 4;
        }
        public Employee(string firstName, string lastName, int empId = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = empId;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public Age Age { get; set; }

        // employee properties
        public int EmployeeId { get; set; }
        public DateOnly StartDate { get; set; }
        public TimeOnly ShiftStartTime { get; set; }
    }

    public class Manager : Employee
    {
        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void SetReports(int numberOfReports)
        {
            NumberOfDirectReports = numberOfReports;
        }

        public int NumberOfDirectReports { get; private set; }
    }

    //structs - value types
    public struct Age
    {
        public Age(DateTime birthDate, int yearsOld)
        {
            BirthDate = birthDate;
            YearsOld = yearsOld;
        }
        public DateTime BirthDate { get; set; }
        public int YearsOld { get; set; }
    }

    public struct VendorContact : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public Age Age { get; set; }
    }

    // struct cannot inherit from base struct
    //public struct BiologicalAge : Age { }

    // records (C# 9)
    public record class Customer : IPerson
    {
        public Customer()
        {
        }
        public Customer(string firstName)
        {
            FirstName = firstName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public Age Age { get; set; }
    }

    public record PremiereCustomer : Customer
    {
        public byte CustomerLevel { get; init; }
    }

    // record structs (C# 10)
    public record struct Order
    {
        public int OrderId { get; set; }
        public DateOnly OrderDate { get; set; }
    }

    //public record struct RecurringOrder : Order
    //{

    //}
}
