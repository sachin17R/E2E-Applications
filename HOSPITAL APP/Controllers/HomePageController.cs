using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatientDataAccessLib.DataComponents;

namespace Hospital_Application.Controllers
{
    public class HomePageController : Controller
    {
        private readonly PatientRepo repo = new PatientRepo();
        // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Allpatient()
        {
            var allpatient = repo.GetAllPatients();
            return View(allpatient);
        }

        public ActionResult Alldocs()
        {
            var alldoc = repo.GetAllDoctors();
            return View(alldoc);
        }

        public ActionResult Addnewpat()
        {
            var adddoc = repo.GetAllDoctors();
            var doclist = new List<SelectListItem>();
            foreach (var item in adddoc)
            {
                var one = new SelectListItem { Text = item.DoctorName, Value = item.DoctorId.ToString() };
                doclist.Add(one);
            }

            TempData["AllDoc"] = doclist;

            return View(new tblPatient());
        }

        [HttpPost]
        public ActionResult Addnewpat(tblPatient data)
        {
            repo.AddPatient(data);
            TempData["success"] = "Patient added Successfully";
            return RedirectToAction("Index");
        }

        public ActionResult Addnewdoc()
        {
            return View(new tblDoctor());
        }

        [HttpPost]
        public ActionResult Addnewdoc(tblDoctor data)
        {
            repo.AddDoctor(data);
            TempData["success"] = "Doctor Added Successfully";
            return RedirectToAction("Index");
        }

        public ActionResult Editpat(string id)
        {
            var adddoc = repo.GetAllDoctors();
            var doclist = new List<SelectListItem>();
            foreach (var item in adddoc)
            {
                var one = new SelectListItem { Text = item.DoctorName, Value = item.DoctorId.ToString() };
                doclist.Add(one);
            }

            TempData["AllDoc"] = doclist;
            var selected = repo.FindPatient(int.Parse(id));

            return View(selected);
        }

        [HttpPost]
        public ActionResult Editpat(tblPatient data)
        {
            repo.UpdatePatient(data);
            TempData["success"] = "Patient Details Updated Successfully";
            return RedirectToAction("Index");
        }

        public ActionResult Delpat(string id)
        {
            var selected = repo.FindPatient(int.Parse(id));
            return View(selected);
        }

        [HttpPost]
        public ActionResult Delpat(tblPatient data)
        {
            repo.RemovePatient(data.PatientId);
            TempData["success"] = "Patient Data Removed Successfully";
            return RedirectToAction("Index");
        }







    }
}