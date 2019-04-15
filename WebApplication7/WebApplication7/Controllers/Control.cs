using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult inicio()
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

        public ActionResult Consulta()
        {
            ViewBag.Message = "Your consulta page.";
           return View();
        }

        public ActionResult lista()
        {
            ViewBag.Message = "Your consulta list.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your consulta login.";

            return View();
        }
    }
}