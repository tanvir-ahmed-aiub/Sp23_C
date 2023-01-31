using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class DotNetController : Controller
    {
        public ActionResult Home() { 
            return View();
        }
        public ActionResult About() {
            return View();
        }
        public ActionResult Contact() {
            return View();
        }
        
    }
}