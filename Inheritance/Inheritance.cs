using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BasePerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public BasePerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual void DisplayInformation()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
        }
    }
    public class Student : BasePerson
    {

        public string StudentNumber { get; set; }


        public Student(string firstName, string lastName, string studentNumber)
            : base(firstName, lastName)
        {
            StudentNumber = studentNumber;
        }


        public override void DisplayInformation()
        {
            Console.WriteLine("Student Information:");
            base.DisplayInformation();
            Console.WriteLine($"Student Number: {StudentNumber}");
        }
    }
    public class Teacher : BasePerson
    {

        public decimal Salary { get; set; }

        public Teacher(string firstName, string lastName, decimal salary)
            : base(firstName, lastName)
        {
            Salary = salary;
        }
        public override void DisplayInformation()
        {
            Console.WriteLine("Teacher Information:");
            base.DisplayInformation();
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
