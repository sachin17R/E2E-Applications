using HospitalSoftware.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSoftware.WebForms
{
    public partial class ConsulationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                HelperClass.populateDoctors(dpdoctors, Application["Doctors"]);
        }

        protected void dpdoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(dpdoctors.SelectedValue);
            var repoo = Application["Patients"] as Patientrepo;
            var allpatients = repoo.GetPatients(id);
            dppatientlist.DataSource = allpatients;
            dppatientlist.DataTextField = "PatientName";
            dppatientlist.DataValueField = "PatientId";
            dppatientlist.DataBind();
        }

        protected void dppatientlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dppatientlist.SelectedValue);
            var repo = Application["Patients"] as Patientrepo;
            var selected = repo.FindPatient(id);
            txtpatid.Text = selected.PatientId.ToString();
            txtname.Text = selected.PatientName;
            txtage.Text = selected.Age.ToString();
            txtmobile.Text = selected.PatientMobile.ToString();
        }
    }
}