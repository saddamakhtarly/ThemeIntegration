using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Theme.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult I401()
        {
            return View();
        }


        public ActionResult I404()
        {
            return View();
        }

        public ActionResult I500()
        {
            return View();
        }
        public ActionResult Charts()
        {
            return View();
        }


        public ActionResult LayoutSidenavLight()
        {
            return View();
        }

        public ActionResult layoutStatic()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Password()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }


        public ActionResult Tables()
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
    }
}