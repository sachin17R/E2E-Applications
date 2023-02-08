using HospitalSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace HospitalSoftware
{
    public class HelperClass
    {
        public  static void populateDoctors(DropDownList dplist,object data)
        {
            var doc = data as List<Doctor>;
            dplist.DataSource = doc;
            dplist.DataTextField = "DoctorName";
            dplist.DataValueField = "DoctorId";
            dplist.DataBind();
        }
    }
}