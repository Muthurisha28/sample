using Citybusdemo.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Citybusdemo.DAL.Repository
{
    public interface IEmployeeDetailsRepository
    {
        public void AddEmployeeDetails(EmployeeDetails employeedetails);
       //  public void UpdateEmployeeDetails(EmployeeDetails empdetails);
       // public void DeleteEmployeeDetails(int empid);
        public EmployeeDetails GetEmpId(int empid);
        IEnumerable<EmployeeDetails> GetEmployeeDetails();
    }
}
