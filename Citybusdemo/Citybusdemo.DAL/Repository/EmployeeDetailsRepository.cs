using Citybusdemo.DAL.Data;
using Citybusdemo.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Citybusdemo.DAL.Repository
{
    public class EmployeeDetailsRepository : IEmployeeDetailsRepository
    {
        EmployeeDetailsDbContext _employeeDetailsDbContext;
        public EmployeeDetailsRepository(EmployeeDetailsDbContext employeeDetailsDbContext)
        {
            _employeeDetailsDbContext =employeeDetailsDbContext;
        }
        public void AddEmployeeDetails(EmployeeDetails employeedetails)
        {
            _employeeDetailsDbContext.empdetails.Add(employeedetails);
            _employeeDetailsDbContext.SaveChanges();
        }

      /*  public void DeleteEmployeeDetails(int empid)
        {
            var employeedetails = _employeeDetailsDbContext.empdetails.Find(empid);
            _employeeDetailsDbContext.empdetails.Remove(employeedetails);
            _employeeDetailsDbContext.SaveChanges();

        } */

        public EmployeeDetails GetEmpId(int empid)
        {
            return _employeeDetailsDbContext.empdetails.Find(empid);


        }

        public IEnumerable<EmployeeDetails> GetEmployeeDetails()
        {
            return _employeeDetailsDbContext.empdetails.ToList();
        }

/*public void UpdateEmployeeDetails(EmployeeDetails empdetails)
        {
            _employeeDetailsDbContext.Entry(empdetails).State = EntityState.Modified;
            _employeeDetailsDbContext.SaveChanges();

        } */
    }
}
