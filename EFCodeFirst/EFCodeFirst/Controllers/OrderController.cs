using EFCodeFirst.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index(int id=1)
        {
            var db = new PMSContext();
            int itemperpage = 20;
            var products = db.Products.OrderBy(e=>e.Id).Skip((id-1)*itemperpage).Take(itemperpage).ToList();
            
            var pagescount = Math.Ceiling( db.Products.Count() / (decimal)itemperpage);
            ViewBag.Pages = pagescount;
            return View(products);
        }
    }
}