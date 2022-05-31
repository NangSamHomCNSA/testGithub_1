using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testGithub_1.Controllers
{
    public class HomeController : Controller
    {
        //testgithub_テストThelThel
        public ActionResult Index()
        {
            return View();
        }
        //zee
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //testingテタ
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //hello testing by thel
    }
}