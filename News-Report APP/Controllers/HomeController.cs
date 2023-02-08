using NewsApplication1.DataComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var repo = new NewsRepooo();
            var data = repo.GetAllNews();
            return View(data);
        }

        public ActionResult More(string id)
        {
            int id1;
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Message = "The Id Is Not Found";
                return ViewBag;
            }
            else{
                id1= int.Parse(id);
               
            }
            var repo = new NewsRepooo();
            var model = repo.viewnews(id1);
            if(model == null)
            {
                ViewBag.Message = "The Id Is Not Found";
                return ViewBag;
            }
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(NewsReport data)
        {
            var repo = new NewsRepooo();
            repo.AddNews(data);
            return RedirectToAction("Index");
        }

        public ActionResult Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                ViewBag.Message = "Please Enter Valid Data To find";
                return View();
            }
            var repo = new NewsRepooo();
            var Alldata = repo.FindNews(query);
            if(Alldata.Count == 0)
            {
                ViewBag.Message = "No Data Found ";
                return View();
            }
            return View(Alldata);

        }
    }
    
}