﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TekDesk_Server.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
