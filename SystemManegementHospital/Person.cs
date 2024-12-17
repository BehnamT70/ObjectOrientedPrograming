using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementHospital
{
    public abstract class Person
    {
        // Propertise
        public string Name { get; set; }
        public int Age { get; set; }
        public string NationalId { get; set; }

        // Constructor
        public Person(string name, int age, string nationalId)
        {
            Name = name;
            Age = age;
            NationalId = nationalId;
        }

        public virtual string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}, National ID: {NationalId}";
        }
    }
}
