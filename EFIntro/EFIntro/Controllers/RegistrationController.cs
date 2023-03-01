using EFIntro.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFIntro.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            UMSSp23_CEntities db = new UMSSp23_CEntities();

            return View(db.Courses.ToList());
        }
    }
}