using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst_Model_Library
{
    public class EmployeeDataContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
