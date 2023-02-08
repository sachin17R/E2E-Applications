using HospitalSoftware.DataModels;
using HospitalSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSoftware.WebForms
{
    public partial class RegisterPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                HelperClass.populateDoctors(dpdoctors, Application["Doctors"]);

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {

            var repo = Application["Patients"] as Patientrepo;
            var patient1 = new Patient
            {
                DOB = DateTime.Parse(txtdob.Text),
                PatientMobile = long.Parse(txtmobile.Text),
                PatientName = txtname.Text,
                DoctorId = int.Parse(dpdoctors.SelectedValue)
            };

            repo.RegisterNewPatient(patient1);
            Application["Patients"] = repo;
            lbldisplay.Text = "Patient Registered Successfully!!!";
            txtdob.Text = "";
            txtmobile.Text = "";
            txtname.Text = "";
        }
    }
}