using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomePageController : Controller
    {

        // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string[] id)
        {


            return RedirectToAction("Index");
        }
    }
}