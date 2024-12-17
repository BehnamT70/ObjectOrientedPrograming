using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementHospital
{
    public class Patient:Person
    {
        // Propertise
        public string PatientId { get; set; }
        public List<string> MedicalHistory { get; set; }

        // Constructor
        public Patient(string name, int age, string nationalId, string patientId)
            : base(name, age, nationalId)
        {
            PatientId = patientId;
            MedicalHistory = new List<string>();
        }

        public void AddToMedicalHistory(string condition)
        {
            MedicalHistory.Add(condition);
        }

        public override string GetDetails()
        {
            return $"{base.GetDetails()}, Patient ID: {PatientId}, Medical History: {string.Join(", ", MedicalHistory)}";
        }
    }
}
