using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    using System;

    public abstract class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        protected Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract void DisplayInformation();
    }

    public class Student : Person
    {
        public string StudentNumber { get; private set; }

        public Student(string firstName, string lastName, string studentNumber)
            : base(firstName, lastName)
        {
            StudentNumber = studentNumber;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine($"Student Information:\nName: {FirstName}\nLast Name: {LastName}\nStudent Number: {StudentNumber}");
        }
    }

    public class Teacher : Person
    {
        public decimal Salary { get; private set; }

        public Teacher(string firstName, string lastName, decimal salary)
            : base(firstName, lastName)
        {
            Salary = salary;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine($"Teacher Information:\nName: {FirstName}\nLast Name: {LastName}\nSalary: {Salary}");
        }
    }
}
