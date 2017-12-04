using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dilan.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Hakkimda()
        {
            return View();
        }

        public ActionResult Projeler()
        {
            return View();
        }

        public ActionResult İletisim()
        {
            return View();
        }


    }
}