using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS4790IA1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hybred DB Example";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact Info.";

            return View();
        }
    }
}