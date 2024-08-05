using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    using System;

    public class BasePerson
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public BasePerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        
        public void DisplayInformation()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}");
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

        
        public void DisplayStudentInformation()
        {
            Console.WriteLine($"Student Number: {StudentNumber}");
            DisplayInformation(); 
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

        
        public void DisplayTeacherInformation()
        {
            Console.WriteLine($"Salary: {Salary}");
            DisplayInformation(); 
        }
    }
}
