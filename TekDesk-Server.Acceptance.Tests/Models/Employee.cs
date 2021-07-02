using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TekDesk_Server.Acceptance.Tests.Models
{
    public class Employee
    {
        
        //public int EmployeeID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
