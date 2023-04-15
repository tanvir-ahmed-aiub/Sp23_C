using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class LoginRepo : Repo, IRepo<Login, string, bool>,IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var res = (from u in db.Logins
                       where u.Username.Equals(username)
                       && u.Password.Equals(password)
                       select u).SingleOrDefault();
            if (res != null) return true;
            return false;
        }


        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Login> Get()
        {
            throw new NotImplementedException();
        }

        public Login Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Login obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Login obj)
        {
            throw new NotImplementedException();
        }
    }
}
