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
            return new EmployeeRepoV2();
        }
        public static IRepo<Course,int,Course> CourseData() { 
            return new CourseRepo();
        }
    }
}
