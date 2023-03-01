using EFCodeFirst.Auth;
using EFCodeFirst.EF.Models;
using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    [Logged]
    public class HomeController : Controller
    {
        [AdminAccess]
        public ActionResult AllOrders() {
            var db = new PMSContext();
            return View(db.Orders.ToList());
        }
        [AdminAccess]
        public ActionResult Details(int id) {
            var db = new PMSContext();
            var order = db.Orders.Find(id);
            return View(order);
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login() { 
            return View();  
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginModel login) {
            if (ModelState.IsValid) {
                PMSContext db = new PMSContext();
                var user = (from u in db.Users
                            where u.Username.Equals(login.Username)
                            && u.Password.Equals(login.Password)
                            select u).SingleOrDefault();
                if (user != null)
                {
                    Session["user"] = user;
                    var returnUrl = Request["ReturnUrl"];
                    if(returnUrl != null)
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Order");
                }
                TempData["Msg"] = "Username Password Invalid";
            }
            return View(login);
            
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