using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmployeeRepo
    {
        static EmpContext db;
        static EmployeeRepo() { 
            db = new EmpContext();
        }
        public static List<Employee> Get() {
             return db.Employees.ToList();
            //List<Employee> emps = new List<Employee>();
            //for(int i = 1; i <= 12; i++)
            //{
            //    emps.Add(new Employee() { Id = i, Name = "E-" + i });
            //}
            //return emps;
        }
        public static Employee Get(int id) {
            return db.Employees.Find(id);
        }
        public static bool Create(Employee emp) {
            db.Employees.Add(emp);
            return db.SaveChanges() > 0;
        }

        public static bool Update(Employee emp) {
            var exempp = Get(emp.Id);
            db.Entry(exempp).CurrentValues.SetValues(emp);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id) {
            var exemp = Get(id);
            db.Employees.Remove(exemp);
            return db.SaveChanges() > 0;
        }

    }
}
