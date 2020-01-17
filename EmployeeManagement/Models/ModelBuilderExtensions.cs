using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Dukre",
                   Department = Dept.Development,
                   Email = "dukre@atidan.com"
               },
                new Employee
                {
                    Id = 2,
                    Name = "Sidhu",
                    Department = Dept.IT,
                    Email = "sidhu@atidan.com"
                }
               );
        }
    }
}
