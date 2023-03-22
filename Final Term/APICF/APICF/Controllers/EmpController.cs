using APICF.EF;
using APICF.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICF.Controllers
{
    public class EmpController : ApiController
    {
        [HttpGet]
        [Route("api/employees")]
        public HttpResponseMessage AllEmployees() {
            EFContext db = new EFContext();
            var data = db.Employees.ToList();
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }
        [HttpGet]
        [Route("api/employees/{id}")]
        public HttpResponseMessage GetEmp(int id) {
            EFContext db = new EFContext();
            var emp = db.Employees.Find(id);
            if (emp != null) { 
                return Request.CreateResponse(HttpStatusCode.OK,emp);
            }

            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
        [HttpPost]
        [Route("api/employees/add")]
        public HttpResponseMessage Add(Employee emp) {
            EFContext db = new EFContext();
            try
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex) { 
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            } 
        }

        [HttpPost]
        [Route("api/employees/update")]
        public HttpResponseMessage UpdateEmp(Employee emp) {
            EFContext db = new EFContext();
            var exemp = db.Employees.Find(emp.Id);
            if (exemp != null) {
                db.Entry(exemp).CurrentValues.SetValues(emp);
                try
                {
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception ex) {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            return Request.CreateResponse(HttpStatusCode.NotFound,"User Not found");
        }


    }
}
