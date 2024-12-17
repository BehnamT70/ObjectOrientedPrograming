using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementHospital
{
    public static class PersonFactory
    {
        public static Person CreatePerson(string type, string name, int age, string nationalId, string id, string extra = null)
        {
            return type.ToLower() switch
            {
                "patient" => new Patient(name, age, nationalId, id),
                "doctor" => new Doctor(name, age, nationalId, id, extra),
                _ => throw new ArgumentException("Invalid Person Type."),
            };
        }
    }
}
