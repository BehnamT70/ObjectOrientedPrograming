using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementHospital
{
    public class DoctorWithStrategy:Doctor
    {
        private IdiagnosisStrategy _strategy;

        public DoctorWithStrategy(string name, int age, string nationalId, string doctorId, string specialization, IdiagnosisStrategy strategy)
            : base(name, age, nationalId, doctorId, specialization)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IdiagnosisStrategy strategy)
        {
            _strategy = strategy;
        }

        public override void Diagnose(Patient patient, string diagnosis)
        {
            _strategy.Diagnose(patient, diagnosis);
        }
    }
}
