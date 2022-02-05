using Citybusdemo.DAL.Repository;
using Citybusdemo.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Citybusdemo.BAL.Service
{
   public  class EmployeeDetailsService
    {
        IEmployeeDetailsRepository _employeeDetailsRepository;

        public EmployeeDetailsService(IEmployeeDetailsRepository employeeDetailsRepository)
        {
            _employeeDetailsRepository = employeeDetailsRepository;
        }
        public void AddEmployeeDetails(EmployeeDetails empdetails)
        {
            _employeeDetailsRepository.AddEmployeeDetails(empdetails);
        }
     /*   public void DeleteEmployeeDetails(int empid)
        {
            _employeeDetailsRepository.DeleteEmployeeDetails(empid);
        }
        public void UpdateEmployeeDetails(EmployeeDetails empdetails)
        {
            _employeeDetailsRepository.UpdateEmployeeDetails(empdetails);
        } */
        public void GetEmpId(int empid)
        {
            _employeeDetailsRepository.GetEmpId(empid);
        }
    }
}
