using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementHospital
{
    public class GeneralDiagnosisStrategy:IdiagnosisStrategy
    {
        public void Diagnose(Patient patient, string diagnosis)
        {
            Console.WriteLine($"General Diagnosis: {diagnosis}");
            patient.AddToMedicalHistory(diagnosis);
        }
    }
}
