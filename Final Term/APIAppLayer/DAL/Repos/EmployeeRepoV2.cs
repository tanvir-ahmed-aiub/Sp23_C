using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeRepoV2 : Repo, IRepo<Employee, int, bool>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }

        public bool Insert(Employee obj)
        {
            db.Employees.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Employee obj)
        {
            throw new NotImplementedException();
        }
    }
}
