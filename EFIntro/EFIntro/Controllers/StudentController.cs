using EFIntro.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFIntro.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult List()
        {
            var db = new UMSSp23_CEntities();
            return View(db.Students.ToList());
        }
        public ActionResult Details(int id) {
            UMSSp23_CEntities db = new UMSSp23_CEntities();
            var st = from s in db.Students
                     where s.Id == id
                     select s;
            return View(st);
        }
    }
}