using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementUniversity
{
    public class Person
    {
        // Propertise
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // A Method That Returns Person Information
        public virtual string GetDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
