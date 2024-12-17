using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementUniversity
{
    public class Professor : Person
    {
        // Propertise
        public string ProfessorID { get; set; }
        public string Subject { get; set; }

        // Constructor
        public Professor(string name, int age, string professorID, string subject)
            : base(name, age)
        {
            ProfessorID = professorID;
            Subject = subject;
        }

        // Override The GetDetails Method To Display Teacher Information
        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Professor ID: {ProfessorID}, Subject: {Subject}";
        }
    }
}
