using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataPassingLayouts.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.Title = "Index";
            return View();
        }
        public ActionResult MyProfile()
        {
            ViewBag.Title = "Profile";
            ViewBag.Name = "Tanvir";
            ViewBag.Section = "C";
            ViewData["Students"] = 41;
            
            return View();
        }
        public ActionResult Settings()
        {
            ViewBag.Title = "Settings";
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Home","Pages");
        }
    }
}