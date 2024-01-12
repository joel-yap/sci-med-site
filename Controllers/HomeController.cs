using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _158258_Assignment_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Medicine()
        {
            return View();
        }

        public ActionResult Antibiotics()
        {
            return View();
        }

        public ActionResult Vaccines()
        {
            return View();
        }

        public ActionResult References()
        {
            return View();
        }

    }
}