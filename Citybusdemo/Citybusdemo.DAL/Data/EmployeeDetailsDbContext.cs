using Citybusdemo.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Citybusdemo.DAL.Data
{
    public class EmployeeDetailsDbContext:DbContext
    {
         
        public EmployeeDetailsDbContext(DbContextOptions<EmployeeDetailsDbContext> options) : base(options)
        {
        }

        public DbSet<EmployeeDetails> empdetails { get; set; }
   
       
    }


}

