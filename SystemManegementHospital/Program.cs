namespace SystemManegementHospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hospital = Hospital.Instance;

            // Create Room
            hospital.Rooms.Add(new Room(101, 2));
            hospital.Rooms.Add(new Room(102, 1));

            // Create Doctor & Patient
            var doctor1 = (Doctor)PersonFactory.CreatePerson("doctor", "Dr. Akbari", 45, "123456", "D001", "Cardiology");
            var patient1 = (Patient)PersonFactory.CreatePerson("patient", "Imani", 30, "654321", "P001");
            var patient2 = (Patient)PersonFactory.CreatePerson("patient", "Ramezani", 25, "987654", "P002");

            hospital.Doctors.Add(doctor1);

            // Patient Admission
            hospital.AdmitPatient(patient1);
            hospital.AdmitPatient(patient2);

            // Diagnosis
            doctor1.Diagnose(patient1, "Common Cold");

            // Patient Discharge
            hospital.DischargePatient(patient1);
        }
    }
}