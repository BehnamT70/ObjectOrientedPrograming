using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementHospital
{
    public class Doctor : Person
    {
        // Propertise
        public string DoctorId { get; set; }
        public string Specialization { get; set; }

        // Constructor
        public Doctor(string name, int age, string nationalId, string doctorId, string specialization)
            : base(name, age, nationalId)
        {
            DoctorId = doctorId;
            Specialization = specialization;
        }

        public virtual void Diagnose(Patient patient, string diagnosis)
        {
            Console.WriteLine($"Doctor {Name} (Specialization: {Specialization}) Diagnosed {patient.Name} with {diagnosis}.");
            patient.AddToMedicalHistory(diagnosis);
        }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Doctor ID: {DoctorId}, Specialization: {Specialization}";
        }
    }
}
