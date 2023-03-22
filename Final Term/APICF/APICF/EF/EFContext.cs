using APICF.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APICF.EF
{
    public class EFContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}