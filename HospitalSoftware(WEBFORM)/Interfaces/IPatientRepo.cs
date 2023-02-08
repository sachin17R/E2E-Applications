using HospitalSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSoftware.Interfaces
{
    interface IPatientRepo
    {
        void RegisterNewPatient(Patient patient);
        void UpdatePatient(Patient patient);
        List<Patient> GetPatients(int DocId);
        Patient FindPatient(int PatId);
    }
}
