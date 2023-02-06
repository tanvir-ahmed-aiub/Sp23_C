using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Index(int a=0) {
        //public ActionResult Index(FormCollection form)
        //public ActionResult Index(string Uname, string Pass)
        public ActionResult Index(Login loging)
        {
            //ViewBag.Name = Request["Uname"];
            //ViewBag.Password = Request["Pass"];

            //ViewBag.Name = Uname;
            //ViewBag.Password = Pass;
            //ViewBag.Msg = "This is post";
            //ViewBag.Data = loging;
            return View(loging);
        }
        public ActionResult About()
        {
            Product[] products = new Product[10];
            for (int i = 0; i < 10; i++)
            {
                //products[i] = new Product();
                //products[i].Name = "P-" + (i+1);
                //products[i].Price = 45;
                //products[i].Id = i+1;
                products[i] = new Product() { 
                    Id = i+1,
                    Name = "P-"+(i+1),
                    Price = 45
                };
            }
            

            return View(products);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}