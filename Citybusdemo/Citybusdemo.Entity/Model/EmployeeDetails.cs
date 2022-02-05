using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Citybusdemo.Entity.Model
{
   public class EmployeeDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int empid { get; set; }

        public string empName { get; set; }

        public string empType { get; set; }
    }
}
