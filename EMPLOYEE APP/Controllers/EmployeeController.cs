using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeApplication.ViewModelFolder;
using EmployeeLib.DataClasses;

namespace EmployeeApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        private readonly EmployeeDataComponent repo = new EmployeeDataComponent();
        public ActionResult Index()
        {
     
            return View();
        }

        public ActionResult AllEmp()
        {
            var model = repo.GetAllEmployee();
            return PartialView(model);
        }
        public ActionResult AddNew()
        {
            return PartialView(new ViewModelClass());
        }

        [HttpPost]
        public ActionResult AddNew(ViewModelClass model,string Alldep)
        {
            if (ModelState.IsValid)
            {
                model.deptId = int.Parse(Alldep);
                var emp = new Employee
                {
                    EmpName = model.Name,
                    Address = model.Address,
                    Salary = model.salary,
                    DeptId = model.deptId
                };
                repo.AddNewEmployee(emp);
                return RedirectToAction("Index");
            }
            else
            {
                return PartialView(model);
            }
        }

        public ActionResult Update(string id)
        {
            var id1 = int.Parse(id);
           var selected= repo.FindEmp(id1);
            var alldep = new List<SelectListItem>();
            var data = repo.GetAllDept();
            foreach (var item in data)
            {
                var single = new SelectListItem { Text = item.DeptName, Value = item.DeptId.ToString() };
                alldep.Add(single);
            }
            TempData["AllDept"] = alldep;
            return PartialView(selected);
        }

        [HttpPost]
        public ActionResult Update(Employee model)
        {
           // model.DeptId = int.Parse(Alldep);
            repo.UpdateEmployee(model);
            return RedirectToAction("index");
        }

      
        public ActionResult delete(string id)
        {
            var id1 = int.Parse(id);
            repo.DeleteEmployee(id1);
            return RedirectToAction("AllEmp");
        }



    }
}