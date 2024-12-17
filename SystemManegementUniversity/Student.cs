using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementUniversity
{
    public class Student:Person
    {
        // Propertise
        public string StudentID { get; set; }
        public string Major { get; set; }

        // Constructor
        public Student(string name, int age, string studentID, string major)
            : base(name, age)
        {
            StudentID = studentID;
            Major = major;
        }

        // Override The GetDetails Method To Display Student Information
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Student ID: {StudentID}, Major: {Major}";
        }
    }
}
