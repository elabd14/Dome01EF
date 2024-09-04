using Dome01EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome01EF.Contexct
{
    internal class EnterpriceG03DbContexct : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        //optionsBuilder.UseSqlServer("Data sorce = . ; Initail Catalong = EnterpriseGr03;UserId=Hamda ; Password= 123 ");
        optionsBuilder.UseSqlServer("Server = . ; Database = EnterpriseGr03; Trusted_Connection= true ");

         }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<project> Projects { get; set; }
        public DbSet<Product> products {  get; set; }      

    }
}
