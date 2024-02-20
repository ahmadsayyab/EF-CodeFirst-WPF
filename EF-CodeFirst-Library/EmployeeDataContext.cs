using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_Library
{
    public class EmployeeDataContext : DbContext
    {
        public EmployeeDataContext() { }
        public DbSet<Employee> Employees { get; set; }


    }
}
