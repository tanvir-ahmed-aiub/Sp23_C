using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class StudentController : ApiController
    {
        public List<string> Get() {
            var names = new string[] { "Tabassum", "Nayeema", "Fatima", "Juhair", "Samin" };
            return names.ToList();
        }
        public string Post() {
            return "Post method called";
        }
    }
}
