using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManegementHospital
{
    public class Room
    {
        // Propertise
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; }

        // Constructor
        public Room(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            Patients = new List<Patient>();
        }

        public void AssignPatient(Patient patient)
        {
            if (Patients.Count >= Capacity)
            {
                throw new RoomFullException($"Room {RoomNumber} Is Full.");
            }
            Patients.Add(patient);
        }

        public void RemovePatient(Patient patient)
        {
            Patients.Remove(patient);
        }
    }
}
