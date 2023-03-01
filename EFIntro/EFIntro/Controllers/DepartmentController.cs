using EFIntro.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFIntro.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult List()
        {
            UMSSp23_CEntities db = new UMSSp23_CEntities();
            return View(db.Departments.ToList());
        }
        public ActionResult Details(int id)
        {
            UMSSp23_CEntities db = new UMSSp23_CEntities();
            var exd = from d in db.Departments
                      where d.Id == id
                      select d;
            return View(exd.SingleOrDefault());
        }
    }
}