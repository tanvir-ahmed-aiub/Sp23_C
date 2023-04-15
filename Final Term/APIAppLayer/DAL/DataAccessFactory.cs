using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Employee,int,bool> EmployeeData() {
            return new EmployeeRepo();
        }
        public static IRepo<Course,int,Course> CourseData() { 
            return new CourseRepo();
        }
        public static IRepo<Login, string, bool> LoginData() {
            return new LoginRepo();
        }
        public static IAuth<bool> AuthData() {
            return new LoginRepo();
        }
    }
}
