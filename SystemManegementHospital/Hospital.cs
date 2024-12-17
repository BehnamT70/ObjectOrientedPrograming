using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementHospital
{
    public sealed class Hospital
    {
        private static readonly Hospital _instance = new Hospital();
        public List<Doctor> Doctors { get; private set; }
        public List<Room> Rooms { get; private set; }

        private Hospital()
        {
            Doctors = new List<Doctor>();
            Rooms = new List<Room>();
        }

        public static Hospital Instance => _instance;

        public void AdmitPatient(Patient patient)
        {
            foreach (var room in Rooms)
            {
                try
                {
                    room.AssignPatient(patient);
                    Console.WriteLine($"Patient {patient.Name} Admitted To Room {room.RoomNumber}.");
                    return;
                }
                catch (RoomFullException)
                {
                    // Try The Next Room
                }
            }
            Console.WriteLine("No Available Rooms For The Patient.");
        }

        public void DischargePatient(Patient patient)
        {
            foreach (var room in Rooms)
            {
                if (room.Patients.Contains(patient))
                {
                    room.RemovePatient(patient);
                    Console.WriteLine($"Patient {patient.Name} Has Been Discharged From Room {room.RoomNumber}.");
                    return;
                }
            }
            Console.WriteLine("Patient Not Found In Any Room.");
        }
    }
}
