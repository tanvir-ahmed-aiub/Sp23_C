using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseRepo : Repo, IRepo<Course, int, Course>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> Get()
        {
            throw new NotImplementedException();
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public Course Insert(Course obj)
        {
            db.Courses.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Course Update(Course obj)
        {
            throw new NotImplementedException();
        }
    }
}
