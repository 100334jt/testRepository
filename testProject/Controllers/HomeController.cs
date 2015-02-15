using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello world";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "my test project in a branch";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public String SayHello()
        {
            return "Hello world";
        }
    }
}