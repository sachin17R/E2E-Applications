using HospitalSoftware.Interfaces;
using HospitalSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalSoftware.DataModels
{
    public class DoctorRepo
    {
        public List<Doctor> AllDoctors => new List<Doctor>
        {
            new Doctor{DoctorId=111,DoctorName="Sachin",Fees=500,Specialization="Cardiology"},
            new Doctor{DoctorId=112,DoctorName="Pavan",Fees=700,Specialization="Gynocologist"},
            new Doctor{DoctorId=113,DoctorName="Vishwas",Fees=600,Specialization="Physcian"}
        };
    }

    public class Patientrepo : IPatientRepo
    {
        private List<Patient> Patients = new List<Patient>();

        public Patientrepo()
        {
            
        }
        public Patientrepo(List<Patient> oldRec)
        {
            Patients = oldRec;
        }
        public Patient FindPatient(int PatId) => Patients.Find((p) => p.PatientId == PatId);


        public List<Patient> GetPatients(int DocId) => Patients.FindAll((p) => p.DoctorId == DocId);


        public void RegisterNewPatient(Patient patient)
        {
            var id = 1;
            if (Patients.Count != 0)
            {
                var last= Patients[Patients.Count - 1].PatientId;
                id = ++last;
            }
            patient.PatientId = id;
            Patients.Add(patient);
        }
        

        public void UpdatePatient(Patient patient)
        {
            var selected = FindPatient(patient.PatientId);
            if (selected == null)
                throw new Exception("Patient Not Found To Update");
            selected.PatientMobile = patient.PatientMobile;
            selected.PatientName = patient.PatientName;
            selected.DOB = patient.DOB;


        }
    }

    public class BillingRepo
    {
        public List<Billing> Bills;

        public BillingRepo(List<Billing> oldbills)
        {
            AllBills = oldbills;
        }

        public void AddBill(Patient billpatient)
        {
            int billNo = Bills.LastOrDefault().BillNo;
            Billing bill = new Billing();
            bill.BillNo = ++billNo;
            bill.BillDate = DateTime.Now.Date;
            bill.PatientId = billpatient.PatientId;
            bill.BillAmount = fetchfees(billpatient.DoctorId);

            Bills.Add(bill);
        }

        public List<Billing> AllBills = new List<Billing>();
        private int fetchfees(int doctorId)
        {
            DoctorRepo repo = new DoctorRepo();
            var selected = repo.AllDoctors.Find((d) => d.DoctorId == doctorId);
            return selected.Fees;
        }
    }
}