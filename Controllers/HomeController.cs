using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIS4800_940.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Temi's first MVC app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information for Temiloluwa Olubakinde.";

            return View();
        }
    }
}