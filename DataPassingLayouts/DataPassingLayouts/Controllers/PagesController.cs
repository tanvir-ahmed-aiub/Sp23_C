using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataPassingLayouts.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Home() {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult LoginSubmit() {
            /////some condition
            //redirection
            TempData["Msg"] = "Login Successfull";
            return RedirectToAction("Index", "Dashboard");
            //return Redirect("https://www.aiub.edu");

        }
    }
}