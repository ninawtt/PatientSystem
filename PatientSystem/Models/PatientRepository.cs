using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientSystem.Models
{
    public static class PatientRepository
    {
        private static List<Patient> patients = new List<Patient>();

        public static IEnumerable<Patient> Patients
        {
            get
            {
                return patients;
            }
        }

        public static void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }
    }
}
