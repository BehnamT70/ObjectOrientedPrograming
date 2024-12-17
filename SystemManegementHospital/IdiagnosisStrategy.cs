using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementHospital
{
    public interface IdiagnosisStrategy
    {
        void Diagnose(Patient patient, string diagnosis);
    }
}
